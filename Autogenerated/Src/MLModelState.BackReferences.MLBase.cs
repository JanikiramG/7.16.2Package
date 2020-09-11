namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLModelState

	/// <exclude/>
	public class MLModelState : Terrasoft.Configuration.MLModelState
	{

		#region Constructors: Public

		public MLModelState(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLModelState(Terrasoft.Configuration.MLModelState source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MLModel> MLModelCollectionByState {
			get;
			set;
		}

		public IEnumerable<MLTrainSession> MLTrainSessionCollectionByState {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

