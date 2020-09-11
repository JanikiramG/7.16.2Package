namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleActionType

	/// <exclude/>
	public class SysModuleActionType : Terrasoft.Configuration.SysModuleActionType
	{

		#region Constructors: Public

		public SysModuleActionType(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleActionType(Terrasoft.Configuration.SysModuleActionType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysModuleAction> SysModuleActionCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

