namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ReportFolder

	/// <exclude/>
	public class ReportFolder : Terrasoft.Configuration.ReportFolder
	{

		#region Constructors: Public

		public ReportFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ReportFolder(Terrasoft.Configuration.ReportFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ReportFolder> ReportFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<ReportInFolder> ReportInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

