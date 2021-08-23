using System;
using System.Linq;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using NLog;
using Novell.Directory.Ldap;
using SCG.ARS.BOI.WEB.Configuration;
using SCG.ARS.BOI.WEB.Models;

namespace SCG.ARS.BOI.WEB.Services
{
    public class LdapAuthenticationService : IAuthenticationService
    {
        static NLog.Logger logger = LogManager.GetCurrentClassLogger();
        private const string MemberOfAttribute = "memberOf";
        private const string DisplayNameAttribute = "displayName";
        private const string SAMAccountNameAttribute = "sAMAccountName";
        private const string EmailAttribute = "mail";
        private const string DepartmentAttribute = "department";

        private readonly LdapSetting _config;
        private readonly LdapConnection _connection;

        public LdapAuthenticationService(IOptions<LdapSetting> config)
        {
            _config = config.Value;
            _connection = new LdapConnection
            {
                SecureSocketLayer = true
            };
        }

        public Users Login(string username, string password)
        {
            var port = _config.isSecure ? LdapConnection.DefaultSslPort : LdapConnection.DefaultPort;
            try
            {
                _connection.SecureSocketLayer = _config.isSecure;
                _connection.Connect(_config.Url, port);
                _connection.Bind(_config.BindDn, _config.BindCredentials);

                var searchFilter = _config.SearchFilter.Replace("))",$")(sAMAccountName={username}))");
                // //var searchFilter = "(objectclass=*)";//string.Format (_config.SearchFilter, username);
                // //var searchFilter = "(cn=*)";
                // //string searchFilter = $"(samaccountname=*)";
                // string[] attributes = new string[] { "cn", "userPrincipalName", "st", "givenname", "samaccountname",
                // "description", "telephonenumber", "department", "displayname", "name", "mail", "givenName", "sn" };

                // LdapSearchQueue queue = _connection.Search(
                //         _config.SearchBase,
                //         LdapConnection.SCOPE_SUB,
                //         searchFilter,
                //         attributes,
                //         false,
                //         (LdapSearchQueue)null,
                //         (LdapSearchConstraints)null);

                // LdapMessage message;

                // while ((message = queue.getResponse()) != null)
                // {
                //     if (message is LdapSearchResult)
                //     {
                //         LdapEntry entry = ((LdapSearchResult)message).Entry;

                //         LdapAttributeSet attributeSet = entry.getAttributeSet();

                //         // users.Add(new Users
                //         // {

                //             string Cn = attributeSet.getAttribute("cn")?.StringValue;
                //             string UserPrincipalName = attributeSet.getAttribute("userPrincipalName")?.StringValue;
                //             string St = attributeSet.getAttribute("st")?.StringValue;
                //             string Givenname = attributeSet.getAttribute("givenname")?.StringValue;
                //             string Samaccountname = attributeSet.getAttribute("samaccountname")?.StringValue;
                //             string Description = attributeSet.getAttribute("description")?.StringValue;
                //             string Telephonenumber = attributeSet.getAttribute("telephonenumber")?.StringValue;
                //             string Department = attributeSet.getAttribute("department")?.StringValue;
                //             string Displayname = attributeSet.getAttribute("displayname")?.StringValue;
                //             string Name = attributeSet.getAttribute("name")?.StringValue;
                //             string Mail = attributeSet.getAttribute("mail")?.StringValue;
                //             string GivenName = attributeSet.getAttribute("givenName")?.StringValue;
                //             string Sn = attributeSet.getAttribute("sn")?.StringValue;

                //             Console.WriteLine($"{Cn}, {UserPrincipalName}, {St}, {Givenname}, {Samaccountname}, {Description}, {Telephonenumber}, {Department}, {Displayname}, {Name}, {Mail}, {GivenName}, {Sn}");
                //         //});
                //     }
                // }

                var result = _connection.Search(
                    _config.SearchBase,
                    LdapConnection.ScopeSub,
                    searchFilter,
                    new[] { MemberOfAttribute, DisplayNameAttribute, SAMAccountNameAttribute, EmailAttribute, DepartmentAttribute },
                    false
                );
                var user = result.Next();
                if (user != null)
                {
                    _connection.Bind(user.Dn, password);
                    if (_connection.Bound)
                    {
                        var userEmail = user.GetAttribute(EmailAttribute);
                        var userDept = user.GetAttribute(DepartmentAttribute);

                        return new Users
                        {
                            User_Name = user.GetAttribute(DisplayNameAttribute).StringValue,
                            User_Code = user.GetAttribute(SAMAccountNameAttribute).StringValue,
                            User_Email = userEmail != null ? userEmail.StringValue : "",
                            User_Department = userDept != null ? userDept.StringValue : "",
                            IsAdmin = false //user.getAttribute(MemberOfAttribute).StringValueArray.Contains(_config.AdminCn)
                        };
                    }
                }
            }
            catch(LdapException ex){
                logger.Info($"{ex.Message} for user {username}");
            }
            catch(Exception ex){
                logger.Error(ex, ex.Message);
            }
            _connection.Disconnect();
            return null;
        }

    }
}