namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLTaskStartMethod

	/// <exclude/>
	public class MLTaskStartMethod : Terrasoft.Configuration.MLTaskStartMethod
	{

		#region Constructors: Public

		public MLTaskStartMethod(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLTaskStartMethod(Terrasoft.Configuration.MLTaskStartMethod source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MLModel> MLModelCollectionByBatchPredictionStartMethod {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

