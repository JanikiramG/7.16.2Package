namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProcessUserTaskInFolder

	/// <exclude/>
	public class SysProcessUserTaskInFolder : Terrasoft.Configuration.SysProcessUserTaskInFolder
	{

		#region Constructors: Public

		public SysProcessUserTaskInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProcessUserTaskInFolder(Terrasoft.Configuration.SysProcessUserTaskInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

