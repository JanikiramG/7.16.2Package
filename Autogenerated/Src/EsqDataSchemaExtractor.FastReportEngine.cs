namespace Terrasoft.Configuration.Reporting.FastReportEngine.Esq
{
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Configuration.Reporting.FastReport;
	using Terrasoft.Core;
	using Terrasoft.Nui.ServiceModel.Extensions;
	using Terrasoft.Reporting.DataSource.Abstractions;
	using Terrasoft.Reporting.DataSource.Abstractions.Data;

	#region Class: EsqDataSelectExtractor

	public class EsqDataSchemaExtractor : IDataSchemaExtractor<ReportDataSourceConfiguration<EsqReportDataSourceConfigurationData>>
	{

		#region Fields: Private

		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public EsqDataSchemaExtractor(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private DataSchemaColumn ConvertToDataSchemaColumn(string columnAlias, EsqDataSchemaColumn esqDataSchemaColumn) {
			//TODO CRM-54293
			var coreDataValueType = esqDataSchemaColumn.DataValueType.ToDataValueType(_userConnection);
			if (coreDataValueType.IsLookup) {
				return new ReferenceDataSchemaColumn(
					columnAlias,
					coreDataValueType.ValueType,
					esqDataSchemaColumn.ReferenceSchemaName,
					esqDataSchemaColumn.ReferenceColumnName);
			}
			return new DataSchemaColumn(
				columnAlias,
				coreDataValueType.ValueType);
		}

		private DataSchema ConvertToDataSchema(EsqDataSchema esqDataSchema) {
			return new DataSchema(
				esqDataSchema.Name,
				esqDataSchema.Columns.Select(x => ConvertToDataSchemaColumn(x.Key, x.Value)));
		}

		#endregion

		#region Methods: Public

		public IEnumerable<DataSchema> Extract(ReportDataSourceConfiguration<EsqReportDataSourceConfigurationData> configuration) {
			return configuration.Data.Schemas.Select(x => ConvertToDataSchema(x.Value));
		}

		#endregion

	}

	#endregion

}

