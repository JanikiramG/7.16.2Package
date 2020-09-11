namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysProcessEntity

	/// <exclude/>
	public class VwSysProcessEntity : Terrasoft.Configuration.VwSysProcessEntity
	{

		#region Constructors: Public

		public VwSysProcessEntity(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysProcessEntity(Terrasoft.Configuration.VwSysProcessEntity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

