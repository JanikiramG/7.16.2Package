namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: IntegrationDirection

	/// <exclude/>
	public class IntegrationDirection : Terrasoft.Configuration.IntegrationDirection
	{

		#region Constructors: Public

		public IntegrationDirection(UserConnection userConnection)
			: base(userConnection) {
		}

		public IntegrationDirection(Terrasoft.Configuration.IntegrationDirection source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<IntegrationLog> IntegrationLogCollectionByDirection {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

