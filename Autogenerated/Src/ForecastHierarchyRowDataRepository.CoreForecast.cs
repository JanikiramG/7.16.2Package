namespace Terrasoft.Configuration.ForecastV2
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using Terrasoft.Core;
	using Terrasoft.Common;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.DB;

	#region Interface: IForecastHierarchyRowDataRepository

	/// <summary>
	/// Provides methods to retrieve the data hierarchy of the records in the forecast.
	/// </summary>
	public interface IForecastHierarchyRowDataRepository
	{

		/// <summary>
		/// Gets the hierarchy rows.
		/// </summary>
		/// <param name="forecastEntityUId">The forecast entity identifier.</param>
		/// <param name="hierarchy">The hierarchy.</param>
		/// <param name="recordsIds">The records ids.</param>
		/// <returns>Collection of <see cref="HierarchyRow"/></returns>
		IEnumerable<HierarchyRow> GetHierarchyRows(Sheet sheet,
			IEnumerable<HierarchySettingItem> hierarchy, PageableConfig pageableConfig);

	}

	/// <summary>
	/// The hierarchy row.
	/// </summary>
	public class HierarchyRow
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the record identifier.
		/// </summary>
		/// <value>
		/// The record identifier.
		/// </value>
		public Guid RecordId { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		public string Value { get; set; }

		#endregion

	}

	#endregion

	#region Class: ForecastHierarchyRowDataRepository

	/// <summary>
	/// Provides methods to retrieve the data hierarchy of the records in the forecast.
	/// </summary>
	/// <seealso cref="IForecastHierarchyRowDataRepository" />
	[DefaultBinding(typeof(IForecastHierarchyRowDataRepository))]
	public class ForecastHierarchyRowDataRepository : IForecastHierarchyRowDataRepository
	{

		#region Constants

		private const string ForecastEntityAlias = "FE";
		private const string ForecastRowAlias = "FR";
		private const string LczIdColumnName = "RecordId";
		private const string IdColumnName = "Id";
		private const string ForecastRowSchemaName = "ForecastRow";

		#endregion

		#region Constructors: Public

		public ForecastHierarchyRowDataRepository(UserConnection userConnection) {
			userConnection.CheckArgumentNull(nameof(userConnection));
			UserConnection = userConnection;
		}

		#endregion

		#region Properties

		protected UserConnection UserConnection { get; }

		#endregion Properties

		#region Methods: Private

		private Select GetForecastEntitySelect(string forecastEntityName, Sheet sheet) {
			EntitySchema entityInCellSchema = UserConnection.EntitySchemaManager.GetInstanceByUId(sheet.ForecastEntityInCellUId);
			string entityInCellSchemaName = entityInCellSchema.Name;
			var forecastEntityColumnValueName = sheet.GetEntityReferenceColumn(UserConnection)?.ColumnValueName;
			Select select = new Select(UserConnection)
				.From(forecastEntityName).As(ForecastEntityAlias)
				.Join(JoinType.Inner, entityInCellSchemaName)
					.On(ForecastEntityAlias, "Id").IsEqual(entityInCellSchemaName, forecastEntityColumnValueName)
					.And(entityInCellSchemaName, "SheetId").IsEqual(Column.Const(sheet.Id)) as Select;
			return select;
		}

		private QueryCondition GetRightsCondition(Select select, EntitySchema forecastEntitySchema) {
			var securityEngine = UserConnection.DBSecurityEngine;
			var rightsCondition = securityEngine.GetRecordsByRightCondition(new RecordsByRightOptions {
				EntitySchemaName = forecastEntitySchema.Name,
				EntitySchemaSourceAlias = select.SourceExpression.Alias,
				RightEntitySchemaName = securityEngine.GetRecordRightsSchemaName(forecastEntitySchema.Name),
				Operation = Core.Configuration.EntitySchemaRecordRightOperation.Read,
				PrimaryColumnName = forecastEntitySchema.GetPrimaryColumnName(),
				UserId = UserConnection.CurrentUser.Id,
				UseDenyRecordRights = forecastEntitySchema.UseDenyRecordRights
			});
			return rightsCondition;
		}

		private void AddConditionsToSelect(Select select, IEnumerable<KeyValuePair<int, string>> columns, IEnumerable<Guid> hierarchyRowsId) {
			columns.ForEach(c => {
				if (c.Key > hierarchyRowsId.Count() - 1) {
					return;
				}
				var value = hierarchyRowsId.ElementAt(c.Key);
				var sourceAlias = select.Columns.GetByAlias($"hierarchyColumn{c.Key}Id")?.SourceAlias;
				if (sourceAlias.IsNotNullOrEmpty()) {
					string columnName = "Id";
					var condition = select.AddCondition(sourceAlias, columnName, LogicalOperation.And);
					if (value.IsEmpty()) {
						condition.IsNull();
					} else {
						condition.IsEqual(Column.Const(value));
					}
				}
			});
		}

		private void AddColumnsToSelect(Select select, EntitySchema entitySchema, IEnumerable<KeyValuePair<int, string>> columns) {
			columns.OrderByDescending(c => c.Key).ForEach(c => {
				var parts = c.Value.Split('.');
				var prevSchemaName = ForecastEntityAlias;
				var prevEntitySchema = entitySchema;
				var index = 0;
				var lastIndex = parts.Count() - 1;
				var prevAlias = prevSchemaName;
				parts.ForEach(p => {
					var hierarchyColumnName = $"hierarchyColumn{c.Key}";
					var isLastPart = index == lastIndex;
					var entityColumn = prevEntitySchema.GetSchemaColumnByPath(p);
					var schema = entityColumn.ReferenceSchema;
					var columnName = entityColumn.Name;
					var nameColumnName = entityColumn.DisplayColumnValueName.Replace(columnName, "");
					var isLeafColumn = entitySchema.PrimaryDisplayColumn.Name.Equals(columnName);
					if (isLeafColumn || schema == null) {
						nameColumnName = columnName;
						SetLeafColumn(select, entitySchema, nameColumnName, hierarchyColumnName);
					}
					else {
						var referenceSchemaName = entityColumn.ReferenceSchema.Name;
						var displayColumn = entityColumn.ReferenceSchema.GetPrimaryDisplayColumn();
						bool isLocalizable = false;
						if (displayColumn != null) {
							isLocalizable = displayColumn.IsLocalizable;
						}
						var refColumnIdName = p + IdColumnName;
						var alias = $"E{index}E{prevSchemaName}{refColumnIdName}";
						string lczAlias = "";
						if (isLocalizable) {
							lczAlias = alias + "lcz";
						}
						if (isLastPart) {
							if (isLocalizable) {
								select.Column(Func.Coalesce(
									new QueryColumnExpression(lczAlias, nameColumnName),
									new QueryColumnExpression(alias, nameColumnName))).As(hierarchyColumnName);
							} else {
								select.Column(alias, nameColumnName).As(hierarchyColumnName);
							}
						}
						if (entityColumn.IsLookupType) {
							string idColumnName = entityColumn.ColumnValueName.Replace(columnName, "");
							if (isLastPart) {
								select.Column(alias, idColumnName).As($"{hierarchyColumnName}{IdColumnName}");
							}
							if (!select.Joins.Exists(alias)) {
								var joinCondition = select.Join(JoinType.LeftOuter, referenceSchemaName).As(alias)
									.On(prevAlias, refColumnIdName).IsEqual(alias, IdColumnName);
								if (isLocalizable) {
									AddLocalizationJoin(select, entityColumn.ReferenceSchema.LocalizationSchemaName, alias, lczAlias);
								}
							}
						}
						prevAlias = alias;
						prevSchemaName = index.ToString();
						prevEntitySchema = schema;
					}
					index++;
				});
			});
			select.Distinct();
		}

		private void SetLeafColumn(Select select, EntitySchema entitySchema, string columnName,
				string hierarchyColumnName) {
			if (entitySchema.PrimaryDisplayColumn.IsLocalizable) {
				var lczAlias = ForecastEntityAlias + "lcz";
				select.Column(Func.Coalesce(new QueryColumnExpression(lczAlias, columnName),
					new QueryColumnExpression(ForecastEntityAlias, columnName))).As(hierarchyColumnName);
				AddLocalizationJoin(select, entitySchema.LocalizationSchemaName, ForecastEntityAlias, lczAlias);
			} else {
				select.Column(ForecastEntityAlias, columnName).As(hierarchyColumnName);
			}
			select.Column(ForecastEntityAlias, "Id").As($"{hierarchyColumnName}Id");
		}

		private void AddLocalizationJoin(Select select, string lczSchemaName, string alias, string lczAlias) {
			if (!select.Joins.Exists(lczSchemaName)) {
				select.Join(JoinType.LeftOuter, lczSchemaName).As(lczAlias)
				.On(alias, IdColumnName)
					.IsEqual(lczAlias, LczIdColumnName)
				.And(lczAlias, "SysCultureId")
					.IsEqual(Column.Parameter(UserConnection.CurrentUser.SysCultureId));
			}
		}

		private Select GetPageableSelect(Select select, PageableConfig pageableConfig) {
			var conditionColumn = select.Columns[0];
			var direction = PageableSelectDirection.First;
			var conditionValue = string.Empty;

			if (pageableConfig.LastValue.IsNotNullOrEmpty()) {
				direction = PageableSelectDirection.Next;
				conditionValue = pageableConfig.LastValue;
			}
			var options = new PageableSelectOptions(null, pageableConfig.RowCount, direction);
			options.AddCondition(conditionColumn, new QueryParameter("columnLastValue", conditionValue));
			Select pageableSelect = select.ToPageable(options);
			return pageableSelect.Top(pageableConfig.RowCount);
		}

		private IEnumerable<HierarchyRow> GetFilledHierarchyRows(Select select, int level, string emptyValue) {
			var result = new List<HierarchyRow>();
			select.ExecuteReader(reader => {
				Guid id = reader.GetColumnValue<Guid>($"hierarchyColumn{level}Id");
				string value = reader.GetColumnValue<string>($"hierarchyColumn{level}");
				if (id.IsEmpty()) {
					value = emptyValue;
				}
				var hierarchyRow = new HierarchyRow() {
					RecordId = id,
					Value = value
				};
				result.Add(hierarchyRow);
			});
			return result;
		}

		private string GetEmptyHierarchyValue(string columnName, EntitySchema entitySchema) {
			string message = new LocalizableString(UserConnection.ResourceStorage,
				nameof(ForecastHierarchyRowDataRepository), "LocalizableStrings.EmptyHierarchyValue.Value");
			var entityColumn = entitySchema.GetSchemaColumnByPath(columnName);
			return string.Format(message, entityColumn.Caption);
		}

		private IDictionary<int, string> GetHierarchyColumns(EntitySchema entitySchema,
				IEnumerable<HierarchySettingItem> hierarchy) {
			var columns = new Dictionary<int, string>();
			if (!hierarchy.IsNullOrEmpty()) {
				foreach (HierarchySettingItem settingItem in hierarchy.OrderBy(a => a.Level)) {
					columns[columns.Keys.Count] = settingItem.ColumnPath;
				}
			}
			var primaryDisplayColumnName = entitySchema.GetPrimaryDisplayColumnName();
			columns[columns.Keys.Count] = primaryDisplayColumnName;
			return columns;
		}

		private void AddForecastRowRightsCondition(Sheet sheet, Select select) {
			EntitySchema entityInCellSchema = UserConnection.EntitySchemaManager
				.GetInstanceByUId(sheet.ForecastEntityInCellUId);
			var securityEngine = UserConnection.DBSecurityEngine;
			EntitySchema forecastRowSchema = UserConnection.EntitySchemaManager.GetInstanceByName(ForecastRowSchemaName);
			var forecastRowCondition = securityEngine.GetRecordsByRightCondition(new RecordsByRightOptions {
				EntitySchemaName = ForecastRowSchemaName,
				EntitySchemaSourceAlias = ForecastRowAlias,
				RightEntitySchemaName = securityEngine.GetRecordRightsSchemaName(ForecastRowSchemaName),
				Operation = Core.Configuration.EntitySchemaRecordRightOperation.Read,
				PrimaryColumnName = IdColumnName,
				UserId = UserConnection.CurrentUser.Id,
				UseDenyRecordRights = forecastRowSchema.UseDenyRecordRights
			});
			if (forecastRowCondition != null) {
				select.InnerJoin(ForecastRowSchemaName).As(ForecastRowAlias).On(ForecastRowAlias, IdColumnName)
            		.IsEqual(entityInCellSchema.Name, "RowId");
				select.AddCondition(forecastRowCondition, LogicalOperation.And);
			}
		}

		private void AddRightsConditions(Sheet sheet, Select select, EntitySchema entitySchema) {
			var rightsCondition = GetRightsCondition(select, entitySchema);
			if (rightsCondition != null) {
				select.AddCondition(rightsCondition, LogicalOperation.And);
			}
			if (UserConnection.GetIsFeatureEnabled("ForecastRowRights")) {
				AddForecastRowRightsCondition(sheet, select);
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Gets the hierarchy rows.
		/// </summary>
		/// <param name="sheet">The forecast sheet <see cref="Sheet" />.</param>
		/// <param name="hierarchy">The hierarchy <see cref="HierarchySettingItem" />.</param>
		/// <param name="pageableConfig">The pageable configuration <see cref="PageableConfig" />.</param>
		/// <returns> Collection of <see cref="HierarchyRow" /></returns>
		public IEnumerable<HierarchyRow> GetHierarchyRows(Sheet sheet,
				IEnumerable<HierarchySettingItem> hierarchy, PageableConfig pageableConfig) {
			sheet.CheckArgumentNull(nameof(sheet));
			pageableConfig.CheckArgumentNull(nameof(pageableConfig));
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(sheet.ForecastEntityUId);
			var level = pageableConfig.HierarchyLevel;
			var columns = GetHierarchyColumns(entitySchema, hierarchy).Where(c => c.Key <= level);
			Select select = GetForecastEntitySelect(entitySchema.Name, sheet);
			AddColumnsToSelect(select, entitySchema, columns);
			AddRightsConditions(sheet, select, entitySchema);
			if (level > 0) {
				AddConditionsToSelect(select, columns.Where(c => c.Key < level), pageableConfig.HierarchyRowsId);
			}
			if (!string.IsNullOrEmpty(pageableConfig.PrimaryFilterValue)) {
				EntitySchema forecastEntitySchema = UserConnection.EntitySchemaManager.GetInstanceByName(entitySchema.Name);
				select.AddCondition(Func.Upper(ForecastEntityAlias, forecastEntitySchema.PrimaryDisplayColumn.Name),
						LogicalOperation.And)
					.IsLike(Column.Parameter($"%{pageableConfig.PrimaryFilterValue.ToUpper()}%"));
			}
			if (pageableConfig.RowCount > 0 && pageableConfig.RowsOffset >= 0) {
				select = GetPageableSelect(select, pageableConfig);
			}
			if (!select.HasOrderByItems) {
				select.OrderByAsc(select.Columns.First());
			}
			var lastHierarchyColumn = columns.First(c => c.Key == level);
			var emptyValue = GetEmptyHierarchyValue(lastHierarchyColumn.Value, entitySchema);
			var result = GetFilledHierarchyRows(select, level, emptyValue);
			return result;
		}

		#endregion

	}

	#endregion

}

