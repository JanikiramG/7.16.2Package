namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysDcmSchemaInSettings

	/// <exclude/>
	public class SysDcmSchemaInSettings : Terrasoft.Configuration.SysDcmSchemaInSettings
	{

		#region Constructors: Public

		public SysDcmSchemaInSettings(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysDcmSchemaInSettings(Terrasoft.Configuration.SysDcmSchemaInSettings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

