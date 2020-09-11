namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ExternalAccessClient

	/// <exclude/>
	public class ExternalAccessClient : Terrasoft.Configuration.ExternalAccessClient
	{

		#region Constructors: Public

		public ExternalAccessClient(UserConnection userConnection)
			: base(userConnection) {
		}

		public ExternalAccessClient(Terrasoft.Configuration.ExternalAccessClient source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ExternalAccess> ExternalAccessCollectionByExternalAccessClient {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

