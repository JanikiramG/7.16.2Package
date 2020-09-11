namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Web.Common;

	#region Class: UserProfileEditService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class UserProfileEditService : BaseService
	{

		#region Fields: Private
		
		/// <summary>
		/// ####### ########## ####### ##### ####### "VwSysAdminUnit".
		/// #### - ### ######## ####### #######, ######## - ### ######## #######.
		/// </summary>
		private Dictionary<string, object> changedValues;
		
		#endregion

		#region Methods: Private

		/// <summary>
		/// ######### ###### ################# # ##### "############".
		/// </summary>
		private void SaveUser() {
			object primaryColumnValue = UserConnection.CurrentUser.Id;
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("VwSysAdminUnit");
			Update update = new Update(UserConnection, "VwSysAdminUnit");
			foreach (KeyValuePair<string, object> item in changedValues) {
				EntitySchemaColumn column = entitySchema.Columns.GetByName(item.Key);
				object columnValue = item.Value;
				if (column.DataValueType is DateTimeDataValueType) {
					columnValue = DataTypeUtilities.ValueAsType<DateTime>(item.Value);
				}
				if (column.ColumnValueName != entitySchema.PrimaryColumn.ColumnValueName) {
					update = update.Set(column.ColumnValueName, Column.Parameter(columnValue, column.DataValueType.Name));
				}
			}
			update = update.Where(entitySchema.PrimaryColumn.ColumnValueName).IsEqual(Column.Parameter(primaryColumnValue)) as Update;
			update.Execute();
		}
		
		#endregion

		#region Methods: Public
		
		/// <summary>
		/// ######### ######### # ####### SysAdminUnit ####### #############.
		/// </summary>
		/// <param name="jsonObject">############### ###### ########## ####### ##### "VwSysAdminUnit".</param>
		/// <returns>##### ##########, #### ### #### ##########, ##### ###### ######.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public string UpdateUserProfile(string jsonObject) {
			string errorMessage = string.Empty;
			changedValues = Json.Deserialize<Dictionary<string, object>>(jsonObject);
			try {
				SaveUser();
			} catch (Exception e) {
				errorMessage = e.Message;
			}
			return errorMessage;
		}
		
		#endregion
	}

	#endregion
}
