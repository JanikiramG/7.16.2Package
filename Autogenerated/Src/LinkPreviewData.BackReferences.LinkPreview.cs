namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LinkPreviewData

	/// <exclude/>
	public class LinkPreviewData : Terrasoft.Configuration.LinkPreviewData
	{

		#region Constructors: Public

		public LinkPreviewData(UserConnection userConnection)
			: base(userConnection) {
		}

		public LinkPreviewData(Terrasoft.Configuration.LinkPreviewData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

