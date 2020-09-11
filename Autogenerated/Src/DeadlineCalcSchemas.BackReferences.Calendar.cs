namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DeadlineCalcSchemas

	/// <exclude/>
	public class DeadlineCalcSchemas : Terrasoft.Configuration.DeadlineCalcSchemas
	{

		#region Constructors: Public

		public DeadlineCalcSchemas(UserConnection userConnection)
			: base(userConnection) {
		}

		public DeadlineCalcSchemas(Terrasoft.Configuration.DeadlineCalcSchemas source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<DeadlineCalcSchemas> DeadlineCalcSchemasCollectionByAlternativeRule {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

