namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwMobileSysSchema

	/// <exclude/>
	public class VwMobileSysSchema : Terrasoft.Configuration.VwMobileSysSchema
	{

		#region Constructors: Public

		public VwMobileSysSchema(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwMobileSysSchema(Terrasoft.Configuration.VwMobileSysSchema source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

