namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLClassificationResult

	/// <exclude/>
	public class MLClassificationResult : Terrasoft.Configuration.MLClassificationResult
	{

		#region Constructors: Public

		public MLClassificationResult(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLClassificationResult(Terrasoft.Configuration.MLClassificationResult source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

