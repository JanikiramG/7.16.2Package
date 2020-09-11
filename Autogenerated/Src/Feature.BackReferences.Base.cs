namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Feature

	/// <exclude/>
	public class Feature : Terrasoft.Configuration.Feature
	{

		#region Constructors: Public

		public Feature(UserConnection userConnection)
			: base(userConnection) {
		}

		public Feature(Terrasoft.Configuration.Feature source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AdminUnitFeatureState> AdminUnitFeatureStateCollectionByFeature {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

