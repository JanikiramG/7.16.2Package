namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ScoringModel

	/// <exclude/>
	public class ScoringModel : Terrasoft.Configuration.ScoringModel
	{

		#region Constructors: Public

		public ScoringModel(UserConnection userConnection)
			: base(userConnection) {
		}

		public ScoringModel(Terrasoft.Configuration.ScoringModel source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ScoringModel> ScoringModelCollectionBySourceModel {
			get;
			set;
		}

		public IEnumerable<ScoringRule> ScoringRuleCollectionByScoringModel {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

