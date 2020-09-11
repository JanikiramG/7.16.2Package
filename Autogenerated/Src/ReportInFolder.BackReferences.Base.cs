namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ReportInFolder

	/// <exclude/>
	public class ReportInFolder : Terrasoft.Configuration.ReportInFolder
	{

		#region Constructors: Public

		public ReportInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ReportInFolder(Terrasoft.Configuration.ReportInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

