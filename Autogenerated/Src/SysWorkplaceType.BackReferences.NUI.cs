namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysWorkplaceType

	/// <exclude/>
	public class SysWorkplaceType : Terrasoft.Configuration.SysWorkplaceType
	{

		#region Constructors: Public

		public SysWorkplaceType(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysWorkplaceType(Terrasoft.Configuration.SysWorkplaceType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysWorkplace> SysWorkplaceCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

