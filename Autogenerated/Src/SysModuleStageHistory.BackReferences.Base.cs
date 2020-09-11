namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleStageHistory

	/// <exclude/>
	public class SysModuleStageHistory : Terrasoft.Configuration.SysModuleStageHistory
	{

		#region Constructors: Public

		public SysModuleStageHistory(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleStageHistory(Terrasoft.Configuration.SysModuleStageHistory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

