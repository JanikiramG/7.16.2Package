namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: HTTPAuthType

	/// <exclude/>
	public class HTTPAuthType : Terrasoft.Configuration.HTTPAuthType
	{

		#region Constructors: Public

		public HTTPAuthType(UserConnection userConnection)
			: base(userConnection) {
		}

		public HTTPAuthType(Terrasoft.Configuration.HTTPAuthType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<WebService> WebServiceCollectionByHTTPAuthType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

