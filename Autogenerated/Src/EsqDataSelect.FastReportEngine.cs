namespace Terrasoft.Configuration.Reporting.FastReportEngine.Esq
{
	using System.Collections.Generic;
	using Terrasoft.Core.Entities;
	using Terrasoft.Reporting.DataSource.Abstractions.Data;

	#region Class: EsqDataSelect

	public class EsqDataSelect : IDataSelect
	{

		#region Constructors: Public

		public EsqDataSelect(EntitySchemaQuery esq, IReadOnlyDictionary<string, string> esqColumnMap) {
			Esq = esq;
			EsqColumnMap = esqColumnMap;
		}

		#endregion

		#region Properties: Public

		public EntitySchemaQuery Esq { get; }

		public IReadOnlyDictionary<string, string> EsqColumnMap { get; }

		#endregion

	}

	#endregion

}

