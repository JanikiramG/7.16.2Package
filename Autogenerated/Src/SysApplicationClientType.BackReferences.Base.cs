namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysApplicationClientType

	/// <exclude/>
	public class SysApplicationClientType : Terrasoft.Configuration.SysApplicationClientType
	{

		#region Constructors: Public

		public SysApplicationClientType(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysApplicationClientType(Terrasoft.Configuration.SysApplicationClientType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysWorkplace> SysWorkplaceCollectionBySysApplicationClientType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

