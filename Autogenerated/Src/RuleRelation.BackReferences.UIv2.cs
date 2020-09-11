namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: RuleRelation

	/// <exclude/>
	public class RuleRelation : Terrasoft.Configuration.RuleRelation
	{

		#region Constructors: Public

		public RuleRelation(UserConnection userConnection)
			: base(userConnection) {
		}

		public RuleRelation(Terrasoft.Configuration.RuleRelation source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

