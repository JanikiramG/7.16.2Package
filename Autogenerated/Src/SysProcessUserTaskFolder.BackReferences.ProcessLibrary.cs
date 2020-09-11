namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProcessUserTaskFolder

	/// <exclude/>
	public class SysProcessUserTaskFolder : Terrasoft.Configuration.SysProcessUserTaskFolder
	{

		#region Constructors: Public

		public SysProcessUserTaskFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProcessUserTaskFolder(Terrasoft.Configuration.SysProcessUserTaskFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysProcessUserTaskFolder> SysProcessUserTaskFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<SysProcessUserTaskInFolder> SysProcessUserTaskInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

