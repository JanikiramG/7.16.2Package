namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysInstalledAppStatus

	/// <exclude/>
	public class SysInstalledAppStatus : Terrasoft.Configuration.SysInstalledAppStatus
	{

		#region Constructors: Public

		public SysInstalledAppStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysInstalledAppStatus(Terrasoft.Configuration.SysInstalledAppStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysInstalledApp> SysInstalledAppCollectionBySysInstalledAppStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

