namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSettingsReferenceSchema

	/// <exclude/>
	public class SysSettingsReferenceSchema : Terrasoft.Configuration.SysSettingsReferenceSchema
	{

		#region Constructors: Public

		public SysSettingsReferenceSchema(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSettingsReferenceSchema(Terrasoft.Configuration.SysSettingsReferenceSchema source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

