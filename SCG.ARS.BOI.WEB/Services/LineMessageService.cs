using System;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NLog;
using SCG.ARS.BOI.WEB.Configuration;

namespace SCG.ARS.BOI.WEB.Services {
    public class LineMessageService : ILineMessageService {
        static Logger logger = LogManager.GetCurrentClassLogger ();
        private readonly IConfiguration _configuration;
        private readonly NotifySetting _notifySetting;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LineMessageService (IConfiguration configuration,
            IOptions<NotifySetting> notifySetting,
            IHttpContextAccessor httpContextAccessor
            ) {
            _configuration = configuration;
            _notifySetting = notifySetting.Value;
            _httpContextAccessor = httpContextAccessor;

        }
        public string SendNotify (string Message) {
            var result = string.Empty;
            try {
                var request = (HttpWebRequest) WebRequest.Create (_notifySetting.Url);
                var postData = $"message={Message}";
                var data = Encoding.UTF8.GetBytes (postData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                request.Headers.Add ("Authorization", $"Bearer {_notifySetting.Authorization}");
                using (var stream = request.GetRequestStream ()) {
                    stream.Write (data, 0, data.Length);
                }

                var response = (HttpWebResponse) request.GetResponse ();
                result = new StreamReader (response.GetResponseStream ()).ReadToEnd ();
            } catch (Exception ex) {
                result = ex.Message;
                logger.Error (ex, $"Exception on SendNotify");
            }

            return result;
        }

		public string SendImage(System.Drawing.Image img, string message) {
			var result = string.Empty;
			try {
				using HttpClient client = new HttpClient();
				client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _notifySetting.Authorization);
				var content = new MultipartFormDataContent();
				content.Add(new StringContent(message), "message");
				using var ms = new MemoryStream();
				img.Save(ms, ImageFormat.Png);
				ms.Position = 0;
				content.Add(new StreamContent(ms), "imageFile", "image.png");
				var ts = client.PostAsync(_notifySetting.Url, content);
				if (ts.Result.StatusCode != HttpStatusCode.OK) {
					result = ts.Result.ToString();
				}
			} catch (Exception ex) {
				result = ex.Message;
				logger.Error(ex, $"Exception on Send Image Line");
			}

			return result;
			/*
			try {
				using var ms = new MemoryStream();
				img.Save(ms, ImageFormat.Png);
				var base64Img = Convert.ToBase64String(ms.ToArray());

				var request = (HttpWebRequest)WebRequest.Create(_notifySetting.Url);
				var postData = $"imageFile={base64Img}";
				var data = Encoding.UTF8.GetBytes(postData);

				request.Method = "POST";
				//request.ContentType = "application/x-www-form-urlencoded"; 
				request.ContentType = "multipart/form-data";
				request.ContentLength = data.Length;
				request.Headers.Add("Authorization", $"Bearer {_notifySetting.Authorization}");

				using (var stream = request.GetRequestStream()) {
					stream.Write(data, 0, data.Length);
				}
				
				var response = (HttpWebResponse)request.GetResponse();
				result = new StreamReader(response.GetResponseStream()).ReadToEnd();
			} catch (Exception ex) {
				result = ex.Message;
				logger.Error(ex, $"Exception on Send Image Line");
			}

			return result;

			*/
		}
	}
}