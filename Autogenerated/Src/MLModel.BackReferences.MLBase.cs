namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLModel

	/// <exclude/>
	public class MLModel : Terrasoft.Configuration.MLModel
	{

		#region Constructors: Public

		public MLModel(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLModel(Terrasoft.Configuration.MLModel source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MLClassificationResult> MLClassificationResultCollectionByModel {
			get;
			set;
		}

		public IEnumerable<MLModelColumn> MLModelColumnCollectionByMLModel {
			get;
			set;
		}

		public IEnumerable<MLModelFile> MLModelFileCollectionByMLModel {
			get;
			set;
		}

		public IEnumerable<MLModelInFolder> MLModelInFolderCollectionByMLModel {
			get;
			set;
		}

		public IEnumerable<MLModelInTag> MLModelInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<MLPrediction> MLPredictionCollectionByModel {
			get;
			set;
		}

		public IEnumerable<MLTrainSession> MLTrainSessionCollectionByMLModel {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

