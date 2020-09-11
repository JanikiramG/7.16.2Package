namespace Terrasoft.Configuration.Reporting.FastReportEngine
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Configuration.Reporting.FastReport;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Reporting.DataSource.Abstractions;
	using Terrasoft.Reporting.FastReport.Abstractions;

	#region Class: FastReportDataSourceBuilderResolver

	public class FastReportDataSourceBuilderResolver : IDataSourceBuilderResolver
	{

		#region Fields: Private

		private readonly UserConnection _userConnection;
		private readonly FastReportDataSourceManager _dataSourceManager;

		#endregion

		#region Constructors: Public

		public FastReportDataSourceBuilderResolver(UserConnection userConnection) {
			_userConnection = userConnection;
			_dataSourceManager = new FastReportDataSourceManager(userConnection);
		}

		#endregion

		#region Methods: Private

		private IDataSourceBuilder CreateDataSourceBuilder(ReportDataSourceMetadata metadata) {
			return ClassFactory.Get<IDataSourceBuilder>(metadata.Type, new ConstructorArgument("userConnection", _userConnection));
		}

		#endregion

		#region Methods: Public

		public IReadOnlyDictionary<Guid, IDataSourceBuilder> ResolveAll(Guid id) {
			var dataSourceMetadataList = _dataSourceManager.GetDataSourceMetadataListByTemplateId(id);
			return dataSourceMetadataList.ToDictionary(x => x.Id, x => CreateDataSourceBuilder(x));
		}

		#endregion

	}

	#endregion

}

