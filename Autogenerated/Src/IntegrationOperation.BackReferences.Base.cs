namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: IntegrationOperation

	/// <exclude/>
	public class IntegrationOperation : Terrasoft.Configuration.IntegrationOperation
	{

		#region Constructors: Public

		public IntegrationOperation(UserConnection userConnection)
			: base(userConnection) {
		}

		public IntegrationOperation(Terrasoft.Configuration.IntegrationOperation source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<IntegrationLog> IntegrationLogCollectionByOperation {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

