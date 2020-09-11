namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: RelationType

	/// <exclude/>
	public class RelationType : Terrasoft.Configuration.RelationType
	{

		#region Constructors: Public

		public RelationType(UserConnection userConnection)
			: base(userConnection) {
		}

		public RelationType(Terrasoft.Configuration.RelationType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Relationship> RelationshipCollectionByRelationType {
			get;
			set;
		}

		public IEnumerable<Relationship> RelationshipCollectionByReverseRelationType {
			get;
			set;
		}

		public IEnumerable<RelationType> RelationTypeCollectionByReverseRelationType {
			get;
			set;
		}

		public IEnumerable<VwAccountRelationship> VwAccountRelationshipCollectionByRelationType {
			get;
			set;
		}

		public IEnumerable<VwAccountRelationship> VwAccountRelationshipCollectionByReverseRelationType {
			get;
			set;
		}

		public IEnumerable<VwContactRelationship> VwContactRelationshipCollectionByRelationType {
			get;
			set;
		}

		public IEnumerable<VwContactRelationship> VwContactRelationshipCollectionByReverseRelationType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

