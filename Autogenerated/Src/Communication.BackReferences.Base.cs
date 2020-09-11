namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Communication

	/// <exclude/>
	public class Communication : Terrasoft.Configuration.Communication
	{

		#region Constructors: Public

		public Communication(UserConnection userConnection)
			: base(userConnection) {
		}

		public Communication(Terrasoft.Configuration.Communication source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ComTypebyCommunication> ComTypebyCommunicationCollectionByCommunication {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

