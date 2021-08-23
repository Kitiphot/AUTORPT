using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;
using Novell.Directory.Ldap;
using Quartz;
using Quartz.Impl;
using Quartz.Logging;
using Quartz.Spi;
using Quartzmin;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Entities.QaDataLakePKGDb;
using SCG.ARS.BOI.WEB.Entities.QaDataLakeWHDb;
using SCG.ARS.BOI.WEB.Helpers;
using SCG.ARS.BOI.WEB.Jobs;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Schedule;
using SCG.ARS.BOI.WEB.Services;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;
using Logger = Quartz.Logging.Logger;
using LogLevel = Quartz.Logging.LogLevel;
using System.Data;
using Npgsql;
using SCG.ARS.BOI.WEB.Repositories;
using SCG.ARS.BOI.WEB.Entities.MasterDb;
using SCG.ARS.BOI.WEB.Models.Master;
using Microsoft.AspNetCore.Identity;
using SCG.ARS.BOI.WEB.Security;
using SCG.ARS.BOI.WEB.Security.Model;
using SCG.ARS.BOI.WEB.Security.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.ResponseCompression;
using System.IO.Compression;
using SCG.ARS.BOI.WEB.GENZ.Repositories;

namespace SCG.ARS.BOI.WEB
{
	public class Startup
	{

		//ILog log = LogManager.GetLogger (typeof (Startup));

		public const string _routePrefix = "/quartzmin";

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
			LogProvider.SetCurrentLogProvider(new ConsoleLogProvider());
		}

		public IConfiguration Configuration { get; set; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			var apiStores = Configuration.GetSection("ApiStores");
			services.Configure<GzipCompressionProviderOptions>(opts => opts.Level = CompressionLevel.Optimal)
			  .Configure<KestrelServerOptions>(opts => opts.AddServerHeader = false)
			  .Configure<IISOptions>(opts => opts.ForwardClientCertificate = false)
			  .Configure<List<ApiStore>>(apiStores);

			services.Configure<KestrelServerOptions>(
				Configuration.GetSection("Kestrel"));

			//services.AddHttpsRedirection(options =>
			//{
			//    options.HttpsPort = 443;
			//});

			// extend for send large JSON
			services.Configure<Microsoft.AspNetCore.Http.Features.FormOptions>(options =>
			{
				options.ValueCountLimit = 8 * 1024; // default is 1024
			});

			services.AddSingleton(Configuration);
			services.Configure<ConnectionStrings>(Configuration.GetSection(ConnectionStrings.Section));
			services.Configure<LdapSetting>(Configuration.GetSection(LdapSetting.Section));
			services.Configure<AppSetting>(Configuration.GetSection(AppSetting.Section));
			services.Configure<SmtpSetting>(Configuration.GetSection(SmtpSetting.Section));
			services.Configure<NotifySetting>(Configuration.GetSection(NotifySetting.Section));

			services.Configure<PowerBISetting>(Configuration.GetSection(PowerBISetting.Section));

			services.AddSingleton<PowerBISetting>(Configuration.GetSection(PowerBISetting.Section).Get<PowerBISetting>());
			// Register AadService and PbiEmbedService for dependency injection
			services.AddScoped(typeof(AadService))
					.AddScoped(typeof(PbiEmbedService));

			//services.AddControllersWithViews();

			//services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			services.AddHttpContextAccessor();
			services.AddScoped<ILdapConnection, LdapConnection>();

			services.AddScoped<DbContext, MasterContext>();
			services.AddScoped<DbContext, QaWHContext>();
			services.AddScoped<DbContext, QaPKGContext>();
			services.AddScoped<DbContext, ApplicationContext>();

			services.AddEntityFrameworkNpgsql()
				.AddDbContext<MasterContext>(options =>
				{
					options.UseNpgsql(Configuration.GetConnectionString("ARSConnection"));
				})
				.BuildServiceProvider();

			services.AddEntityFrameworkNpgsql()
				.AddDbContext<QaWHContext>(options =>
				{
					options.UseNpgsql(Configuration.GetConnectionString("PDLakeConnection"));
				})
				.BuildServiceProvider();

			services.AddEntityFrameworkNpgsql()
				.AddDbContext<QaPKGContext>(options =>
				{
					options.UseNpgsql(Configuration.GetConnectionString("PDLakeConnection"));
				})
				.BuildServiceProvider();

			services.AddDbContext<ApplicationContext>(options =>
			{
				options.UseNpgsql(Configuration.GetConnectionString("PDLakeConnection"));
			});

			services.AddDbContext<SecurityDbContext>(options => {
				options.UseNpgsql(Configuration.GetConnectionString("ARSConnection"));
			});

			services.AddTransient<IMasterRepository, MasterRepository> ();
			services.AddTransient<IReportRepository, ReportRepository> ();
			services.AddTransient<IFunctionTemplateRepository, FunctionTemplateRepository> ();
			services.AddTransient<ILogRepository, LogRepository> ();

			//Security 2020-08-17
			services.AddTransient<IUserRepository, UserRepository>();
			services.AddTransient<IRoleRepository, RoleRepository>();
			services.AddTransient<IPermissionRepository, PermissionRepository>();
			services.AddTransient<ISecurityService, SecurityService>();

			services.AddTransient<INetworking, NetworkingRepository>();
			services.AddSingleton<INetworkingMaster, NetworkingMasterRepository>();

			services.AddTransient<IDataService, DataService>();
			services.AddTransient<IEmailMessageService, EmailMessageService>();
			services.AddTransient<ILineMessageService, LineMessageService>();

			//Generwiz 10-May-2021
			services.AddTransient<IOrderPendingRepository, OrderPendingRepository>();


			//services.AddSingleton<SmtpSetting> ();

			services.AddTransient<SmtpClientEx>((serviceProvider) =>
			{
				var config = new SmtpSetting();
				Configuration.GetSection(SmtpSetting.Section).Bind(config);

				return new SmtpClientEx(config.Domain)
				{
					Host = config.Host,
					Port = config.Port,
					EnableSsl = config.EnableSsl//,
					//Credentials = new NetworkCredential(
					//        config.Username,
					//        config.Password
					//    )
				};
			});

			// Add Quartz services
			services.AddSingleton<IJobFactory, SingletonJobFactory>();
			services.AddSingleton<ISchedulerFactory, StdSchedulerFactoryEx>();

			// Add our job
			services.AddSingleton<HelloWorldJob>();
			services.AddSingleton<PrintMessageJob>();
			services.AddSingleton<EmailMessageJob>();
			services.AddSingleton<EmailSchedulerJob>();
			services.AddSingleton<LineMessageJob>();
			services.AddSingleton<LineMessage2Job>();
			services.AddSingleton<TransportationLineMessageJob>();
			services.AddSingleton<SKICOverallFleetImageLineMessageJob>();

			//services.AddSingleton(new JobSchedule(
			//jobType: typeof(EmailSchedulerJob),
			//cronExpression: "0/5 * * * * ?")); // run every 5 seconds

			services.AddSingleton(new JobSchedule(
				jobType: typeof(HelloWorldJob),
				cronExpression: "0/5 * * * * ?")); // run every 5 seconds

			services.AddSingleton(new JobSchedule(
				jobType: typeof(PrintMessageJob),
				cronExpression: "0/5 * * * * ?")); // run every 5 seconds

			services.Configure<CookiePolicyOptions>(options =>
			{
				// This lambda determines whether user consent for non-essential cookies is needed for a given request.
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});

			IScheduler _scheduler = GetScheduler(services);

			services.AddSingleton<Quartzmin.Services>(provider => {
				var isEmpty = string.IsNullOrEmpty(_routePrefix);

				var options = new QuartzminOptions {
					Scheduler = _scheduler,
					VirtualPathRoot = isEmpty ? string.Empty : _routePrefix
				};

				return Quartzmin.Services.Create(options);
			});
			services.AddScoped<QuartzminFilter>();

			services.AddMvc(options =>
			{
				options.Conventions.Add(new QuartzminConvention());
			})
				.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie(options => {
					options.Cookie.Name = "SCG-ARS";
					options.Cookie.HttpOnly = true;
					//options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
					options.Events.OnRedirectToLogin = (context) => {
						context.Response.Redirect("/Account/Login/");
						//context.Response.StatusCode = 401;
						return Task.CompletedTask;
					};
					options.AccessDeniedPath = "/Account/AccessDenied";
					options.LoginPath = "/Account/Login/";
					options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
					options.SlidingExpiration = true;
					//options.Events.OnSignedIn = (context) => {
					//    var key = Guid.NewGuid().ToString();
					//    context.HttpContext.Response.Cookies.Append("CookieIdent", key);
					//    return Task.CompletedTask;
					//};
				});

			services.AddMemoryCache();

			services.AddQuartzmin ();

			services.AddIdentity<ApplicationUser, ApplicationRole>()
				.AddEntityFrameworkStores<SecurityDbContext>()
				.AddDefaultTokenProviders()
				.AddUserManager<UserManager<ApplicationUser>>()
				.AddRoleManager<RoleManager<ApplicationRole>>()
				.AddSignInManager<SignInManager<ApplicationUser>>();

			services.Configure<IdentityOptions>(options =>
			{
				options.Lockout.MaxFailedAccessAttempts = 10;
				options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(60);
			});
			services.AddHsts(opt =>
			{
				opt.MaxAge = new TimeSpan(30);
				opt.IncludeSubDomains = false;
			});

			services.AddResponseCompression(options =>
			{
				options.Providers.Add<BrotliCompressionProvider>();
				options.Providers.Add<GzipCompressionProvider>();
				options.EnableForHttps = true;
				options.MimeTypes =
					ResponseCompressionDefaults.MimeTypes.Concat(
						new[] { "application/json" });
			});

			services.Configure<BrotliCompressionProviderOptions>(options =>
			{
				options.Level = CompressionLevel.Fastest;
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, IHttpContextAccessor httpContextAccessor)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
				.AddEnvironmentVariables();
			Configuration = builder.Build();

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				//app.UseExceptionHandler("/Maintenance/Page500");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
			}

			app.UseHsts();
			app.UseResponseCompression();

			RewriteOptions options = new RewriteOptions()
				.AddRedirectToProxiedHttps()
				.AddRedirect("(.*)/$", "$1");
			app.UseRewriter(options);

			app.UseForwardedHeaders(GetForwardedHeadersOptions());

			app.UseAuthentication();

			app.UseHttpsRedirection();

			app.UseStaticFiles();

			app.UseCookiePolicy();

//#if !DEBUG
			app.UseQuartzmin(_routePrefix);
//#endif

			app.Use(async (context, next) =>
			{
				context.Response.Headers.Add("X-Frame-Options", "DENY");
				context.Response.Headers["Server"] = "-";
				context.Response.Headers.Add("Strict-Transport-Security", "max-age=31536000; includeSubDomains");

				if (httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
				{

					var serviceProvider = app.ApplicationServices;
					using var scope = serviceProvider.CreateScope();
					ISecurityService ss = scope.ServiceProvider.GetRequiredService<ISecurityService>();
					IPermissionRepository pr = scope.ServiceProvider.GetRequiredService<IPermissionRepository>();
					UserManager<ApplicationUser> usrMngr = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
					string username = httpContextAccessor.HttpContext.User.Identity.Name;
					string cookieToken = context.Request.Cookies["CookieToken"];
					var user = await usrMngr.FindByNameAsync(username);
					
					var isAdmin = await usrMngr.IsInRoleAsync(user, ss.GetAdminRole());
					
					//allow concurrent login for admin user.
					//TODO: Remove when deploy production server
					if (!pr.ValidateCookieToken(context.User.Identity.Name, cookieToken) && !isAdmin)
					{
						var signMngr = scope.ServiceProvider.GetRequiredService<SignInManager<ApplicationUser>>();
						await signMngr.SignOutAsync();
						context.Response.Redirect("/Account/ForceSignOut");
					}
				}
				await next();
			});

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});
		}

		private static IScheduler GetScheduler(IServiceCollection services)
		{
			var provider = services.BuildServiceProvider();
			var factory = (StdSchedulerFactoryEx)provider.GetRequiredService<ISchedulerFactory>();
			var master = (IMasterRepository)provider.GetRequiredService<IMasterRepository>();


			//services.AddSingleton(new JobSchedule(
			//    jobType: typeof(HelloWorldJob),
			//    cronExpression: "0/5 * * * * ?")); // run every 5 seconds

			// services.AddSingleton (new JobSchedule (
			//     jobType: typeof (PrintMessageJob),
			//     cronExpression: "0/5 * * * * ?")); // run every 5 seconds

			//List<EmailScheduler> schedulers = master.GetEmailScheduler(null);
			//var scheduler = schedulers[0];

			//JobDataMap jobDataMap = new JobDataMap();
			//jobDataMap.Put("EmailScheduler", scheduler);

			factory.AddJob<EmailMessageJob>();
			factory.AddJob<EmailSchedulerJob>();
			factory.AddJob<LineMessageJob>();
			factory.AddJob<LineMessage2Job>();
			factory.AddJob<TransportationLineMessageJob>();
			factory.AddJob<SKICOverallFleetImageLineMessageJob>();
			factory.AddJob<PrintMessageJob>();
			factory.AddJob<HelloWorldJob>();



			//IJobDetail EmailSchedulerJob = JobBuilder.Create<EmailSchedulerJob>()
			//                        .WithIdentity(scheduler.email_scheduler_name + " (test)", "Auto Email")
			//                        .UsingJobData(jobDataMap)
			//                        .Build();

			//ITrigger EmailSchedulerTrigger = TriggerBuilder.Create()
			//                                         .WithIdentity(scheduler.email_scheduler_name + " Trigger", "Auto Email Trigger")
			//                                         .WithSimpleSchedule(x => x.WithIntervalInSeconds(10)
			//                                         .RepeatForever())
			//                                         .Build();

			//services.AddSingleton(new JobSchedule(
			//    jobType: typeof(EmailSchedulerJob),
			//    cronExpression: "0/5 * * * * ?")); // run every 5 seconds

			#if !DEBUG
				factory.Start();
			#endif

			//ITrigger trigger1 = TriggerBuilder.Create()
			//            .WithIdentity("test trigger")
			//            .WithSchedule(SimpleScheduleBuilder.Create())
			//            .ForJob("test job name")
			//            .Build();

			//factory.Scheduler.ScheduleJob(trigger1);


			return factory.Scheduler;
		}
		private static ForwardedHeadersOptions GetForwardedHeadersOptions()
		{
			ForwardedHeadersOptions forwardedHeadersOptions = new ForwardedHeadersOptions()
			{
				ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
			};

			forwardedHeadersOptions.KnownNetworks.Clear();
			forwardedHeadersOptions.KnownProxies.Clear();

			return forwardedHeadersOptions;
		}
	}

	public class ConsoleLogProvider : ILogProvider
	{
		public Logger GetLogger(string name)
		{
			return (level, func, exception, parameters) =>
			{
				if (level >= LogLevel.Info && func != null)
				{
					Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] [" + level + "] " + func(), parameters);
					Debug.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] [" + level + "] " + func(), parameters);
				}
				return true;
			};
		}

		public IDisposable OpenNestedContext(string message)
		{
			throw new NotImplementedException();
		}

		public IDisposable OpenMappedContext(string key, string value)
		{
			throw new NotImplementedException();
		}
	}
	public static class RedirectToProxiedHttpsExtensions
	{
		public static RewriteOptions AddRedirectToProxiedHttps(this RewriteOptions options)
		{
			options.Rules.Add(new RedirectToProxiedHttpsRule());
			return options;
		}
	}
	public class RedirectToProxiedHttpsRule : IRule
	{
		public virtual void ApplyRule(RewriteContext context)
		{
			HttpRequest request = context.HttpContext.Request;

			string reqProtocol;
			if (request.Headers.ContainsKey("X-Forwarded-Proto"))
				reqProtocol = request.Headers["X-Forwarded-Proto"][0];
			else
				reqProtocol = (request.IsHttps ? "https" : "http");

			if (reqProtocol != "https")
			{
				StringBuilder newUrl = new StringBuilder()
					.Append("https://").Append(request.Host)
					.Append(request.PathBase).Append(request.Path)
					.Append(request.QueryString);

				context.HttpContext.Response.Redirect(newUrl.ToString(), true);
			}
		}
	}
}