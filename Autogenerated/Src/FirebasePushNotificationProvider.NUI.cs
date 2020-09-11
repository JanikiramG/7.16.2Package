namespace Terrasoft.Configuration
{
	using System;
	using System.Net;
	using System.Runtime.Serialization;
	using System.Text;
	using System.Collections.Generic;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using Terrasoft.Web.Http.Abstractions;

	#region Class: FirebasePushNotificationProvider

	/// <summary>
	/// Firebase push notification provider.
	/// </summary>
	public class FirebasePushNotificationProvider : IPushNotificationProvider
	{

		#region Class: Request

		/// <summary>
		/// Represents push notification request.
		/// </summary>
		[DataContract]
		private class Request
		{

			#region Properties: Public

			/// <summary>
			/// Device token.
			/// </summary>
			[JsonProperty("to")]
			public string Token {
				get;
				set;
			}

			/// <summary>
			/// Message.
			/// </summary>
			[JsonProperty("notification")]
			public NotificationData Notification {
				get;
				set;
			}

			/// <summary>
			/// Message.
			/// </summary>
			[JsonProperty("data")]
			public Dictionary<string, string> Data {
				get;
				set;
			}

			#endregion

		}

		#endregion

		#region Class: NotificationData

		/// <summary>
		/// Represents push notification request data.
		/// </summary>
		[DataContract]
		private class NotificationData
		{

			#region Properties: Public

			/// <summary>
			/// Message.
			/// </summary>
			[JsonProperty("body")]
			public string Message {
				get;
				set;
			}

			/// <summary>
			/// Title.
			/// </summary>
			[JsonProperty("title")]
			public string Title {
				get;
				set;
			}

			/// <summary>
			/// Title.
			/// </summary>
			[JsonProperty("sound")]
			public string Sound {
				get;
				set;
			}

			/// <summary>
			/// Title.
			/// </summary>
			[JsonProperty("icon")]
			public string Icon {
				get;
				set;
			}

			#endregion

		}

		#endregion

		#region Constructors: Public

		public FirebasePushNotificationProvider(string settings) {
			_settings = JObject.Parse(settings);
		}

		#endregion

		#region Properties: Private

		private readonly JObject _settings;

		private string Url {
			get {
				return (string)_settings["url"];
			}
		}

		private string ApiKey {
			get {
				return (string)_settings["apiKey"];
			}
		}

		#endregion

		#region Methods: Private

		private void PostData(string resource, string token, string title, string message,
				Dictionary<string, string> additionalData) {
			var requestBody = new Request {
				Token = token,
				Notification = new NotificationData {
					Message = message,
					Title = title,
					Sound = "default"
				},
				Data = additionalData
			};
			string postData = JsonConvert.SerializeObject(requestBody);
			var uriAddress = new Uri(new Uri(Url), resource);
			using (var webClient = new WebClient()) {
				webClient.Encoding = Encoding.UTF8;
				webClient.Headers.Add("Authorization", "key=" + ApiKey);
				webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
				try {
					string response = webClient.UploadString(uriAddress, "POST", postData);
				} catch (Exception e) {
					throw new HttpException((int)HttpStatusCode.InternalServerError, e.Message);
				}
			}
		}

		#endregion

		#region Methods: Public

		public void Send(PushNotificationData data) {
			PostData("send", data.Token, data.Title, data.Message, data.AdditionalData);
		}

		#endregion

	}

	#endregion
	
}
