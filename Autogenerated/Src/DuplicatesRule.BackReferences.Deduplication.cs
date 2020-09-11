namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DuplicatesRule

	/// <exclude/>
	public class DuplicatesRule : Terrasoft.Configuration.DuplicatesRule
	{

		#region Constructors: Public

		public DuplicatesRule(UserConnection userConnection)
			: base(userConnection) {
		}

		public DuplicatesRule(Terrasoft.Configuration.DuplicatesRule source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<DuplicatesRuleInFolder> DuplicatesRuleInFolderCollectionByDuplicatesRule {
			get;
			set;
		}

		public IEnumerable<DuplicatesRuleInTag> DuplicatesRuleInTagCollectionByEntity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

