namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysDcmUserTask

	/// <exclude/>
	public class SysDcmUserTask : Terrasoft.Configuration.SysDcmUserTask
	{

		#region Constructors: Public

		public SysDcmUserTask(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysDcmUserTask(Terrasoft.Configuration.SysDcmUserTask source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

