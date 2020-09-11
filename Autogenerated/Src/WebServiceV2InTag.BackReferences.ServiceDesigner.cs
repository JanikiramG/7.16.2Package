namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WebServiceV2InTag

	/// <exclude/>
	public class WebServiceV2InTag : Terrasoft.Configuration.WebServiceV2InTag
	{

		#region Constructors: Public

		public WebServiceV2InTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public WebServiceV2InTag(Terrasoft.Configuration.WebServiceV2InTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

