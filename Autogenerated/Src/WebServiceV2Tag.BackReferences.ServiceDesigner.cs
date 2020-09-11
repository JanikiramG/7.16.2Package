namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WebServiceV2Tag

	/// <exclude/>
	public class WebServiceV2Tag : Terrasoft.Configuration.WebServiceV2Tag
	{

		#region Constructors: Public

		public WebServiceV2Tag(UserConnection userConnection)
			: base(userConnection) {
		}

		public WebServiceV2Tag(Terrasoft.Configuration.WebServiceV2Tag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<WebServiceV2InTag> WebServiceV2InTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

