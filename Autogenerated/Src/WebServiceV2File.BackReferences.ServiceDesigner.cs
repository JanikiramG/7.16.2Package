namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WebServiceV2File

	/// <exclude/>
	public class WebServiceV2File : Terrasoft.Configuration.WebServiceV2File
	{

		#region Constructors: Public

		public WebServiceV2File(UserConnection userConnection)
			: base(userConnection) {
		}

		public WebServiceV2File(Terrasoft.Configuration.WebServiceV2File source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

