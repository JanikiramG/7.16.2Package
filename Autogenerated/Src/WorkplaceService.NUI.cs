namespace Terrasoft.Configuration.WorkplaceService
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Configuration.Workplace;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Common;

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class WorkplaceService : BaseService
	{

		#region Constants: Private

		private const string WorkplaceCacheKeyTemplate = "SysWorkplaceId_{0}";
		private const string SysSchemaUIdParameterName = "SysSchemaUId";
		private const string SysWorkspaceIdParameterName = "SysWorkspaceId";

		#endregion

		#region Properties: Protected

		/// <summary>
		/// <see cref="IWorkplaceManager"/> implementation instance.
		/// </summary>
		protected IWorkplaceManager WorkplaceManager {
			get {
				return ClassFactory.Get<IWorkplaceManager>(new ConstructorArgument("uc", UserConnection));
			}
		}

		#endregion

		#region Methods: Private

		private void ResetCache() {
			ConfigurationSectionHelper.ClearCache(UserConnection);
		}

		private string GetWorkplacesScript(Guid applicationClientTypeId) {
			ConfigurationSectionHelper helper = new ConfigurationSectionHelper(UserConnection);
			return helper.GetWorkplacesConfig(UserConnection, true, applicationClientTypeId);
		}

		private void ResetWorkplace() {
			ConfigurationSectionHelper.ResetWorkplaceCache(UserConnection);
		}

		private void SetWorkplaceId(string workplaceId) {
			if (string.IsNullOrEmpty(workplaceId)) {
				return;
			}
			Guid wId = new Guid(workplaceId);
			ConfigurationSectionHelper.SetWorkplaceCache(UserConnection, wId);
		}

		#endregion

		#region Methods: Public

		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public void ResetScriptCache() {
			ResetCache();
		}

		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public void ResetWorkplaceCache() {
			ResetWorkplace();
		}
		
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public void SetWorkplaceCache(string workplaceId) {
			SetWorkplaceId(workplaceId);
		}
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public string RefreshWorkplace(Guid applicationClientTypeId = default(Guid)) {
			return GetWorkplacesScript(applicationClientTypeId);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public IEnumerable<string> GetWorkplacesByType(int type) {
			var result = WorkplaceManager.GetWorkplacesByType((WorkplaceType)type).Select(w => w.ToString());
			return result;
		}

		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public Guid CreateWorkplace(string name, int type) {
			var workplace = WorkplaceManager.CreateWorkplace(name, (WorkplaceType)type);
			return workplace.Id;
		}

		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public void ChangeWorkplaceName(Guid workplaceId, string name) {
			WorkplaceManager.ChangeName(workplaceId, name);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public void ChangeWorkplacePosition(Guid workplaceId, int position) {
			WorkplaceManager.ChangePosition(workplaceId, position);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public void DeleteWorkplace(Guid workplaceId) {
			WorkplaceManager.DeleteWorkplace(workplaceId);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public void AddSectionToWorkplace(Guid workplaceId, Guid sectionId) {
			WorkplaceManager.AddSectionToWorkplace(workplaceId, sectionId);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public void RemoveSectionFromWorkplace(Guid workplaceId, Guid sectionId) {
			WorkplaceManager.RemoveSectionFromWorkplace(workplaceId, sectionId);
		}

		#endregion

	}

}
