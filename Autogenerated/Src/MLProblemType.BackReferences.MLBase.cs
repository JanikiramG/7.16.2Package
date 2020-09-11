namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLProblemType

	/// <exclude/>
	public class MLProblemType : Terrasoft.Configuration.MLProblemType
	{

		#region Constructors: Public

		public MLProblemType(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLProblemType(Terrasoft.Configuration.MLProblemType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MLModel> MLModelCollectionByMLProblemType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

