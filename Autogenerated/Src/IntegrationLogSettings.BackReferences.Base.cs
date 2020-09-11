namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: IntegrationLogSettings

	/// <exclude/>
	public class IntegrationLogSettings : Terrasoft.Configuration.IntegrationLogSettings
	{

		#region Constructors: Public

		public IntegrationLogSettings(UserConnection userConnection)
			: base(userConnection) {
		}

		public IntegrationLogSettings(Terrasoft.Configuration.IntegrationLogSettings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

