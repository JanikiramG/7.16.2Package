namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WebServiceURL

	/// <exclude/>
	public class WebServiceURL : Terrasoft.Configuration.WebServiceURL
	{

		#region Constructors: Public

		public WebServiceURL(UserConnection userConnection)
			: base(userConnection) {
		}

		public WebServiceURL(Terrasoft.Configuration.WebServiceURL source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<WebService> WebServiceCollectionByWebServiceURL {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

