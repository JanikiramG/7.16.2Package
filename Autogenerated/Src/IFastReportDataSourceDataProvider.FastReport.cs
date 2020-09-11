namespace Terrasoft.Configuration.Reporting.FastReport
{
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Terrasoft.Core;

	#region Interface: IFastReportDataSourceDataProvider

	public interface IFastReportDataSourceDataProvider
	{

		#region Methods: Public

		Task<ReportDataDictionary> GetData(UserConnection userConnection, IReadOnlyDictionary<string, object> parameters);

		#endregion

	}

	#endregion

}

