namespace Terrasoft.Configuration
{
	using System;
	using System.Text;
	using System.Collections.Generic;
	using System.Data;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Nui;
	using Terrasoft.Core.DB;

	public class SectionHelper: ISectionHelper {

		#region Methods: Public

		public string GetConfigurationScript(UserConnection userConnection) {
			var helper = ClassFactory.Get<ConfigurationSectionHelper>();
			return helper.GetConfigurationScript(userConnection);
		}

		public string GetClientUnitSchemaDescriptors(UserConnection userConnection) {
			var helper = ClassFactory.Get<ConfigurationSectionHelper>();
			return helper.GetClientUnitSchemaDescriptors(userConnection);
		}

		#endregion

	}
}

