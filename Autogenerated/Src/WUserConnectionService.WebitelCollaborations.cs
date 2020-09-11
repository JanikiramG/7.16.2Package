namespace Terrasoft.Configuration.WUserConnectionService
{
	using System;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Web.Common;

	[DataContract]
	public class WebitelUserConnection {
		[DataMember]
		public string login { get; set; }
		[DataMember]
		public string password { get; set; }
		[DataMember]
		public string customerId { get; set; }
		[DataMember]
		public bool isOperator { get; set; }
		[DataMember]
		public string bindNumber { get; set; }
	}

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class WUserConnectionService : BaseService
	{

		#region Methods: Public

		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public WebitelUserConnection GetUserConnection(string userId) {
			WebitelUserConnection response = new WebitelUserConnection();
			Guid id;
			if (!Guid.TryParse(userId, out id)) {
				return response;
			}
			var esqNumberPlan = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "WSysAccount");
			EntitySchemaQueryColumn entryNumber = esqNumberPlan.AddColumn("Login");
			EntitySchemaQueryColumn entryPassword = esqNumberPlan.AddColumn("Password");
			esqNumberPlan.Filters.Add(esqNumberPlan.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", id)); 
			EntityCollection entitiesNumberPlan = esqNumberPlan.GetEntityCollection(UserConnection);
			if (entitiesNumberPlan.Count > 0) {
				Entity entity = entitiesNumberPlan[0];
				EntitySchemaColumn entryNumberColumnSchema = entity.Schema.Columns.GetByName(entryNumber.Name);
				EntitySchemaColumn entryPasswordColumnSchema = entity.Schema.Columns.GetByName(entryPassword.Name);
				response.login = entity.GetTypedColumnValue<string>(entryNumberColumnSchema.ColumnValueName);
				response.password = entity.GetTypedColumnValue<string>(entryPasswordColumnSchema.ColumnValueName);
			}
			response.customerId = (string)SysSettings.GetValue(UserConnection, "CustomerId");
			return response;
		}
		
		#endregion

	}
}
