namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwDuplicatesRuleType

	/// <exclude/>
	public class VwDuplicatesRuleType : Terrasoft.Configuration.VwDuplicatesRuleType
	{

		#region Constructors: Public

		public VwDuplicatesRuleType(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwDuplicatesRuleType(Terrasoft.Configuration.VwDuplicatesRuleType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<DuplicatesRule> DuplicatesRuleCollectionByObject {
			get;
			set;
		}

		public IEnumerable<DuplicatesRule> DuplicatesRuleCollectionBySearchObject {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

