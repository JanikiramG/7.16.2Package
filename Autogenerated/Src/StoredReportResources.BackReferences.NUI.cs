namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: StoredReportResources

	/// <exclude/>
	public class StoredReportResources : Terrasoft.Configuration.StoredReportResources
	{

		#region Constructors: Public

		public StoredReportResources(UserConnection userConnection)
			: base(userConnection) {
		}

		public StoredReportResources(Terrasoft.Configuration.StoredReportResources source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

