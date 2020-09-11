namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLPrediction

	/// <exclude/>
	public class MLPrediction : Terrasoft.Configuration.MLPrediction
	{

		#region Constructors: Public

		public MLPrediction(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLPrediction(Terrasoft.Configuration.MLPrediction source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

