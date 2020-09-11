namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: IntegrationLog

	/// <exclude/>
	public class IntegrationLog : Terrasoft.Configuration.IntegrationLog
	{

		#region Constructors: Public

		public IntegrationLog(UserConnection userConnection)
			: base(userConnection) {
		}

		public IntegrationLog(Terrasoft.Configuration.IntegrationLog source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

