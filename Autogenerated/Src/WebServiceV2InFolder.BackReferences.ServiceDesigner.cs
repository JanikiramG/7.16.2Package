namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WebServiceV2InFolder

	/// <exclude/>
	public class WebServiceV2InFolder : Terrasoft.Configuration.WebServiceV2InFolder
	{

		#region Constructors: Public

		public WebServiceV2InFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public WebServiceV2InFolder(Terrasoft.Configuration.WebServiceV2InFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

