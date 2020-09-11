namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProcessLogFolder

	/// <exclude/>
	public class SysProcessLogFolder : Terrasoft.Configuration.SysProcessLogFolder
	{

		#region Constructors: Public

		public SysProcessLogFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProcessLogFolder(Terrasoft.Configuration.SysProcessLogFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysProcessLogFolder> SysProcessLogFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<SysProcessLogInFolder> SysProcessLogInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

