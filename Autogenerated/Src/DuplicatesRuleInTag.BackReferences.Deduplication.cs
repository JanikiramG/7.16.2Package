namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DuplicatesRuleInTag

	/// <exclude/>
	public class DuplicatesRuleInTag : Terrasoft.Configuration.DuplicatesRuleInTag
	{

		#region Constructors: Public

		public DuplicatesRuleInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public DuplicatesRuleInTag(Terrasoft.Configuration.DuplicatesRuleInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

