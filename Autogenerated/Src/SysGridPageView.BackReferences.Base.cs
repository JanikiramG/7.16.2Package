namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysGridPageView

	/// <exclude/>
	public class SysGridPageView : Terrasoft.Configuration.SysGridPageView
	{

		#region Constructors: Public

		public SysGridPageView(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysGridPageView(Terrasoft.Configuration.SysGridPageView source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysGridPageView> SysGridPageViewCollectionByParent {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

