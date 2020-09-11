namespace Terrasoft.Configuration.Reporting.FastReportEngine.Esq
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Configuration.Reporting.FastReport;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Reporting.DataSource.Abstractions;

	#region Class: EsqDataSelectExtractor

	public class EsqDataSelectExtractor : IDataSelectExtractor<ReportDataSourceConfiguration<EsqReportDataSourceConfigurationData>, EsqDataSelect>
	{

		#region Fields: Private

		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public EsqDataSelectExtractor(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private EntitySchemaQuery CreateEsqWithColumnMap(
				EsqDataSchema esqDataSchema,
				IReadOnlyDictionary<string, object> parameters,
				out Dictionary<string, string> columnMap) {
			var esq = new EntitySchemaQuery(_userConnection.EntitySchemaManager, esqDataSchema.Name);
			columnMap = new Dictionary<string, string>();
			foreach (var column in esqDataSchema.Columns) {
				columnMap.Add(column.Key, esq.AddColumn(column.Value.Path).Name);
			}
			esq.TryAddFilterFromReportParameters(_userConnection, parameters);
			return esq;
		}

		#endregion

		#region Methods: Public

		public EsqDataSelect Extract(ReportDataSourceConfiguration<EsqReportDataSourceConfigurationData> configuration, string schemaName) {
			if (!configuration.Data.Schemas.TryGetValue(schemaName, out var esqDataSchema)) {
				throw new Exception();
			}
			var esq = CreateEsqWithColumnMap(esqDataSchema, configuration.Parameters, out var columnMap);
			return new EsqDataSelect(esq, columnMap);
		}

		#endregion

	}

	#endregion

}

