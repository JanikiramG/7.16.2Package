namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ScoringRule

	/// <exclude/>
	public class ScoringRule : Terrasoft.Configuration.ScoringRule
	{

		#region Constructors: Public

		public ScoringRule(UserConnection userConnection)
			: base(userConnection) {
		}

		public ScoringRule(Terrasoft.Configuration.ScoringRule source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

