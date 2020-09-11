namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.FileImport;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UpdateSsoContactMethodsWrapper

	/// <exclude/>
	public class UpdateSsoContactMethodsWrapper : ProcessModel
	{

		public UpdateSsoContactMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ActualizeContactScriptTaskExecute", ActualizeContactScriptTaskExecute);
		}

		#region Methods: Private

		private bool ActualizeContactScriptTaskExecute(ProcessExecutingContext context) {
			Dictionary<string, string> contactValues = Json.Deserialize<Dictionary<string, string>>(Get<string>("ClaimData"));
			UserConnection userConnection = Get<UserConnection>("UserConnection");
			var contact = new Terrasoft.Configuration.Contact(userConnection);
			string contactId;
			if (!contactValues.TryGetValue(contact.Schema.GetPrimaryColumnName(), out contactId)) {
				return true;
			}
			if (contact.FetchFromDB(new Guid(contactId))) {
				UpdateContact(contact, contactValues);
				string isNewRecord;
				if (contactValues.TryGetValue("IsNewRecord", out isNewRecord) &&
						isNewRecord.Equals("true", StringComparison.InvariantCultureIgnoreCase)) {
					EntitySchema schema = userConnection.EntitySchemaManager.GetInstanceByName("Contact");
					var userId = new Guid(contactValues["SysAdminUnitId"]);
					userConnection.DBSecurityEngine.AddDefRights(contact.Id, userId, contact.Id, schema);
				}
			}
			return true;
		}

			private void UpdateContact(Entity contact, Dictionary<string, string> contactValues) {
				UserConnection userConnection = Get<UserConnection>("UserConnection");
				var importParamsGenerator = new BaseImportParamsGenerator();
				ImportParameters parameters = importParamsGenerator.GenerateParameters(contact.Schema, contactValues);
				var fileImporter = new FileImporter(userConnection);
				fileImporter.ImportWithParams(parameters);
			}

		#endregion

	}

	#endregion

}

