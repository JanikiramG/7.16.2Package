namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProcessUserTask

	/// <exclude/>
	public class SysProcessUserTask : Terrasoft.Configuration.SysProcessUserTask
	{

		#region Constructors: Public

		public SysProcessUserTask(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProcessUserTask(Terrasoft.Configuration.SysProcessUserTask source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

