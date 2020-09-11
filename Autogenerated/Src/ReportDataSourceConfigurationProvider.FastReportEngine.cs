namespace Terrasoft.Configuration.Reporting.FastReportEngine
{
	using System;
	using System.Threading.Tasks;
	using Terrasoft.Configuration.Reporting.FastReport;
	using Terrasoft.Core;
	using Terrasoft.Reporting.DataSource.Abstractions;

	#region Class: ReportDataSourceConfigurationProvider

	public class ReportDataSourceConfigurationProvider<TReportDataSourceConfigurationData> : IDataSourceConfigurationProvider<ReportDataSourceConfiguration<TReportDataSourceConfigurationData>>
		where TReportDataSourceConfigurationData : class, IReportDataSourceConfigurationData
	{

		#region Fields: Private

		private readonly FastReportDataSourceManager _dataSourceManager;

		#endregion

		#region Constructors: Public

		public ReportDataSourceConfigurationProvider(UserConnection userConnection) {
			_dataSourceManager = new FastReportDataSourceManager(userConnection);
		}

		#endregion

		#region Methods: Public

		public Task<ReportDataSourceConfiguration<TReportDataSourceConfigurationData>> GetConfiguration(Guid dataSourceId) {
			var dataSource = _dataSourceManager.GetDataSource<TReportDataSourceConfigurationData>(dataSourceId);
			return Task.FromResult(new ReportDataSourceConfiguration<TReportDataSourceConfigurationData>(dataSource));
		}

		#endregion

	}

	#endregion

}

