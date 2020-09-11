namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysChartSeriesKind

	/// <exclude/>
	public class SysChartSeriesKind : Terrasoft.Configuration.SysChartSeriesKind
	{

		#region Constructors: Public

		public SysChartSeriesKind(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysChartSeriesKind(Terrasoft.Configuration.SysChartSeriesKind source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

