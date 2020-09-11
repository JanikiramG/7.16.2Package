namespace Terrasoft.Configuration.ForecastV2
{
	using global::Common.Logging;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Interface: IForecastRowRepository

	/// <summary>
	/// Provides methods to get information from forecast row.
	/// </summary>
	public interface IForecastRowRepository
	{
		/// <summary>
		/// The user connection.
		/// </summary>
		/// <returns>Row identifier.</returns>
		UserConnection UserConnection { get; set; }

		/// <summary>
		/// Creates row and return identifier.
		/// </summary>
		/// <returns>Row identifier.</returns>
		Guid Create();

		/// <summary>
		/// Get the list of row ids.
		/// </summary>
		/// <param name="sheet">Forecast sheet info.</param>
		/// <param name="config">Filter configuration.</param>
		/// <returns></returns>
		IEnumerable<Guid> Get(Sheet sheet, FilterConfig config);

		/// <summary>
		/// Remove row by id..
		/// </summary>
		/// <param name="id">Row id.</param>
		/// <returns></returns>
		bool Remove(Guid id);
	}

	#endregion

	#region Class: ForecastRowRepository

	[DefaultBinding(typeof(IForecastRowRepository))]
	public class ForecastRowRepository: IForecastRowRepository
	{
		#region Properties: Private

		private static readonly ILog logger = LogManager.GetLogger<ForecastRowRepository>();
		private Sheet _forecastSheet;

		#endregion

		#region Properties: Public

		private UserConnection _userConnection;

		///<inheritdoc />
		public UserConnection UserConnection {
			get => _userConnection;
			set {
				value.CheckArgumentNull(nameof(UserConnection));
				_userConnection = value;
			}
		}

		#endregion

		#region Properties: Protected

		protected Sheet ForecastSheet {
			get { return _forecastSheet; }
			set {
				value.CheckArgumentNull(nameof(ForecastSheet));
				_forecastSheet = value;
			}
		}

		#endregion

		#region Methods: Private

		private EntitySchemaQuery GetEsq(string schemaName) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, schemaName);
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			return esq;
		}

		private string GetSchemaName(Guid uId) {
			return UserConnection.EntitySchemaManager.FindInstanceByUId(uId).Name;
		}

		private void AddGetMethodFilters(Guid sheetId, FilterConfig config, EntitySchemaQuery esq,
			string entitySchemaName) {
			esq.Filters.LogicalOperation = LogicalOperationStrict.And;
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, entitySchemaName,
				config.RecordIds.Cast<object>()));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Sheet", sheetId));
			esq.Filters.Add(esq.CreateIsNullFilter("Period"));
			esq.Filters.Add(esq.CreateIsNullFilter("ForecastColumn"));
		}

		private string GetReferenceColumnName(EntitySchemaQuery esq, string entitySchemaName) {
			var refColumn = ForecastSheet.GetEntityReferenceColumn(UserConnection);
			if (refColumn == null) {
				string message = $"Reference column for schema {entitySchemaName} not found";
				logger.Error(message);
				throw new ItemNotFoundException(message);
			}
			return refColumn.Name;
		}

		private void AddColumns(EntitySchemaQuery esq, string refColumn) {
			esq.AddColumn(refColumn);
			esq.AddColumn("Row");
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Creates row and return identifier.
		/// </summary>
		/// <returns>Row identifier.</returns>
		public Guid Create() {
			EntitySchema schema = UserConnection.EntitySchemaManager.FindInstanceByName("ForecastRow");
			Entity entity = schema.CreateEntity(UserConnection);
			entity.SetDefColumnValues();
			entity.Save();
			return entity.PrimaryColumnValue;
		}

		///<inheritdoc />
		public IEnumerable<Guid> Get(Sheet sheet, FilterConfig config) {
			sheet.CheckArgumentNull(nameof(sheet));
			config.CheckArgumentNull(nameof(config));
			config.RecordIds.CheckArgumentNullOrEmpty(nameof(config.RecordIds));
			ForecastSheet = sheet;
			string inCellSchemaName = GetSchemaName(ForecastSheet.ForecastEntityInCellUId);
			EntitySchemaQuery esq = GetEsq(inCellSchemaName);
			string entitySchemaName = GetSchemaName(sheet.ForecastEntityUId);
			string refColumnName = GetReferenceColumnName(esq, entitySchemaName);
			AddColumns(esq, refColumnName);
			AddGetMethodFilters(ForecastSheet.Id, config, esq, refColumnName);
			var rowsId = new List<Guid>();
			esq.GetEntityCollection(UserConnection).ForEach(item =>
				rowsId.Add(item.GetTypedColumnValue<Guid>("RowId"))
			);
			return rowsId;
		}

		///<inheritdoc />
		public bool Remove(Guid id) {
			EntitySchemaQuery esq = GetEsq("ForecastRow");
			var entity = esq.GetEntity(UserConnection, id);
			var result = entity?.Delete();
			return result ?? false;
		}

		#endregion

	}

	#endregion

}

