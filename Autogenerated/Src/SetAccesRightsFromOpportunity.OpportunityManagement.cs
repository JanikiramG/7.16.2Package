namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SetAccesRightsFromOpportunityMethodsWrapper

	/// <exclude/>
	public class SetAccesRightsFromOpportunityMethodsWrapper : ProcessModel
	{

		public SetAccesRightsFromOpportunityMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask4Execute", ScriptTask4Execute);
		}

		#region Methods: Private

		private bool ScriptTask4Execute(ProcessExecutingContext context) {
			var isOpportunityRightsUsed = Terrasoft.Configuration.OpportunityManagement.OpportunityManagementUtils
				.GetIsAnySchemaAdministratedByRecords(UserConnection, "Account", "Contact", "Opportunity");
			Set("IsOpportunityRightsUsed", isOpportunityRightsUsed);
			return true;
		}

		#endregion

	}

	#endregion

}

