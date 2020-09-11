namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysGridPage

	/// <exclude/>
	public class SysGridPage : Terrasoft.Configuration.SysGridPage
	{

		#region Constructors: Public

		public SysGridPage(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysGridPage(Terrasoft.Configuration.SysGridPage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysEditPage> SysEditPageCollectionBySysGridPage {
			get;
			set;
		}

		public IEnumerable<SysGridPageView> SysGridPageViewCollectionBySysGridPage {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

