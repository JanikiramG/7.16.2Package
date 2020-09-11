namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwWebServiceV2

	/// <exclude/>
	public class VwWebServiceV2 : Terrasoft.Configuration.VwWebServiceV2
	{

		#region Constructors: Public

		public VwWebServiceV2(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwWebServiceV2(Terrasoft.Configuration.VwWebServiceV2 source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<WebServiceV2File> WebServiceV2FileCollectionByWebServiceV2 {
			get;
			set;
		}

		public IEnumerable<WebServiceV2InFolder> WebServiceV2InFolderCollectionByWebServiceV2 {
			get;
			set;
		}

		public IEnumerable<WebServiceV2InTag> WebServiceV2InTagCollectionByEntity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

