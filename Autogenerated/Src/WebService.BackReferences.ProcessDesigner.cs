namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WebService

	/// <exclude/>
	public class WebService : Terrasoft.Configuration.WebService
	{

		#region Constructors: Public

		public WebService(UserConnection userConnection)
			: base(userConnection) {
		}

		public WebService(Terrasoft.Configuration.WebService source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<WebServiceURL> WebServiceURLCollectionByWebService {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

