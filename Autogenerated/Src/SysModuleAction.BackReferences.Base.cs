namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleAction

	/// <exclude/>
	public class SysModuleAction : Terrasoft.Configuration.SysModuleAction
	{

		#region Constructors: Public

		public SysModuleAction(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleAction(Terrasoft.Configuration.SysModuleAction source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysModuleActionLczOld> SysModuleActionLczOldCollectionByRecord {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

