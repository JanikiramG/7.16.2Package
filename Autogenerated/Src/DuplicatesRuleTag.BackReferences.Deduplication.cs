namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DuplicatesRuleTag

	/// <exclude/>
	public class DuplicatesRuleTag : Terrasoft.Configuration.DuplicatesRuleTag
	{

		#region Constructors: Public

		public DuplicatesRuleTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public DuplicatesRuleTag(Terrasoft.Configuration.DuplicatesRuleTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<DuplicatesRuleInTag> DuplicatesRuleInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

