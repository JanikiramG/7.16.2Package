namespace Terrasoft.Configuration
{
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Common;
	using Terrasoft.ComponentSpace.Interfaces;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Common;
	using Terrasoft.Web.Http.Abstractions;

	#region Class: MainMenuService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class MainMenuService : BaseService
	{

		#region Properties: Private

		private HttpContext Context { get; set; } = HttpContext.Current;

		#endregion

		#region Methods: Public

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "Logout", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		[return: MessageParameter(Name = "RedirectLocation")]
		public string Logout() {
			var samlProviderApi = ClassFactory.Get<ISamlServiceProviderApi>();
			var result = string.Empty;
			if (samlProviderApi.GetCanDoSlo()) {
				result = samlProviderApi.InitiateSlo();
			}
			if (result.IsNullOrEmpty()) {
				var userSessionManager = ClassFactory.Get<IUserSessionManager>();
				userSessionManager.Logout();
			}
			return result;
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetCanAccessConfigurationSettings", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public bool GetCanAccessConfigurationSettings() {
			var operations = new string[] {
				"CanManageAdministration",
				"CanManageProcessDesign",
				"CanManageChangeLog",
				"CanManageSolution",
				"CanManageLookups",
				"CanViewConfiguration"
			};
			var result = false;
			foreach (var operation in operations) {
				result = result || UserConnection.DBSecurityEngine.GetCanExecuteOperation(operation);
				if (result) {
					break;
				}
			}
			return result;
		}

		#endregion

	}

	#endregion

}
