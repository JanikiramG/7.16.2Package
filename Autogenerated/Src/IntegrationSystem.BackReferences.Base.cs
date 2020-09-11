namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: IntegrationSystem

	/// <exclude/>
	public class IntegrationSystem : Terrasoft.Configuration.IntegrationSystem
	{

		#region Constructors: Public

		public IntegrationSystem(UserConnection userConnection)
			: base(userConnection) {
		}

		public IntegrationSystem(Terrasoft.Configuration.IntegrationSystem source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<IntegrationLog> IntegrationLogCollectionByIntegrationSystem {
			get;
			set;
		}

		public IEnumerable<IntegrationLogSettings> IntegrationLogSettingsCollectionByIntegrationSystem {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

