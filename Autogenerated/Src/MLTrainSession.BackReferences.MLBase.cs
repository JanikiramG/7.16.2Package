namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLTrainSession

	/// <exclude/>
	public class MLTrainSession : Terrasoft.Configuration.MLTrainSession
	{

		#region Constructors: Public

		public MLTrainSession(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLTrainSession(Terrasoft.Configuration.MLTrainSession source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

