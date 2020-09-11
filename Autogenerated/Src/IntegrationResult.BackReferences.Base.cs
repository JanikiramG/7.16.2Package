namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: IntegrationResult

	/// <exclude/>
	public class IntegrationResult : Terrasoft.Configuration.IntegrationResult
	{

		#region Constructors: Public

		public IntegrationResult(UserConnection userConnection)
			: base(userConnection) {
		}

		public IntegrationResult(Terrasoft.Configuration.IntegrationResult source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<IntegrationLog> IntegrationLogCollectionByResult {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

