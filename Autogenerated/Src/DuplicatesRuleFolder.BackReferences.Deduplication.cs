namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DuplicatesRuleFolder

	/// <exclude/>
	public class DuplicatesRuleFolder : Terrasoft.Configuration.DuplicatesRuleFolder
	{

		#region Constructors: Public

		public DuplicatesRuleFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public DuplicatesRuleFolder(Terrasoft.Configuration.DuplicatesRuleFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<DuplicatesRuleFolder> DuplicatesRuleFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<DuplicatesRuleInFolder> DuplicatesRuleInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

