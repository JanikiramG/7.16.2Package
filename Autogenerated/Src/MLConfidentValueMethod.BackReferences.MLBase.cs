namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLConfidentValueMethod

	/// <exclude/>
	public class MLConfidentValueMethod : Terrasoft.Configuration.MLConfidentValueMethod
	{

		#region Constructors: Public

		public MLConfidentValueMethod(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLConfidentValueMethod(Terrasoft.Configuration.MLConfidentValueMethod source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MLModel> MLModelCollectionByMLConfidentValueMethod {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

