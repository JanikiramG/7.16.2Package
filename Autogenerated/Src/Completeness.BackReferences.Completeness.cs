namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Completeness

	/// <exclude/>
	public class Completeness : Terrasoft.Configuration.Completeness
	{

		#region Constructors: Public

		public Completeness(UserConnection userConnection)
			: base(userConnection) {
		}

		public Completeness(Terrasoft.Configuration.Completeness source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<CompletenessParameter> CompletenessParameterCollectionByCompleteness {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

