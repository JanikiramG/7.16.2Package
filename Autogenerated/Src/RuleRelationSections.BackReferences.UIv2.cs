namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: RuleRelationSections

	/// <exclude/>
	public class RuleRelationSections : Terrasoft.Configuration.RuleRelationSections
	{

		#region Constructors: Public

		public RuleRelationSections(UserConnection userConnection)
			: base(userConnection) {
		}

		public RuleRelationSections(Terrasoft.Configuration.RuleRelationSections source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

