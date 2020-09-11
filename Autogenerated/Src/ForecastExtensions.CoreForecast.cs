namespace Terrasoft.Configuration.ForecastV2
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;

	#region Class: ForecastExtensions

	/// <summary>
	/// Utilities extensions for forecasts.
	/// </summary>
	public static class ForecastExtensions
	{

		#region Methods: Public

		/// <summary>
		/// Gets periods by ids.
		/// If period ids are empty - returns periods for current year by period type.
		/// </summary>
		/// <param name="periodRepository">Periods repository.</param>
		/// <param name="periodIds">Periods identifiers.</param>
		/// <param name="periodTypeId">Period type identifier.</param>
		/// <returns></returns>
		public static IEnumerable<Period> GetForecastPeriods(this IPeriodRepository periodRepository,
				IEnumerable<Guid> periodIds, Guid periodTypeId) {
			if (periodIds.IsNullOrEmpty()) {
				return periodRepository.GetPeriods(periodTypeId, DateTime.UtcNow.Year);
			}
			return periodRepository.GetPeriods(periodIds);
		}

		/// <summary>
		/// Returns precision of forecast value column.
		/// </summary>
		/// <param name="sheet">Forecast sheet.</param>
		/// <param name="userConnection">User connection.</param>
		/// <returns></returns>
		public static int GetForecastValueColumnPrecision(this Sheet sheet, UserConnection userConnection) {
			var column = sheet.GetEntityInForecastValueColumn(userConnection);
			var valueType = column.DataValueType as FloatDataValueType;
			return valueType.Precision;
		}

		/// <summary>
		/// Checks cell value according to forecast sheet's entity's value column size.
		/// </summary>
		/// <param name="sheet">Forecast sheet.</param>
		/// <param name="userConnection">User connection.</param>
		/// <param name="value">Cell value.</param>
		/// <returns>Cell value does not exceed column size and can be safely used for operations.</returns>
		public static bool CheckForecastValueExceedMaxSize(this Sheet sheet, UserConnection userConnection,
				decimal value) {
			var column = sheet.GetEntityInForecastValueColumn(userConnection);
			var valueType = column.DataValueType as FloatDataValueType;
			int decimalSizeLimit = valueType.DBSize - valueType.DBPrecision;
			int decimalPartLength = Math.Truncate(value).ToString().Length;
			return decimalPartLength > decimalSizeLimit;
		}

		/// <summary>
		/// Forms hierarchy filter items collection from sheet's hierarchy settings.
		/// </summary>
		/// <param name="sheet"></param>
		/// <param name="hierarchyRowIds"></param>
		/// <returns></returns>
		public static IEnumerable<HierarchyFilterItem> FormHierarchyFilter(this Sheet sheet,
			IEnumerable<Guid> hierarchyRowIds) {
			var hierarchyFilter = new List<HierarchyFilterItem>();
			int index = 0;
			IEnumerable<HierarchySettingItem> sheetHierarchyList = sheet.GetHierarchyItems();
			hierarchyRowIds?.ForEach(hierarchyId => {
				hierarchyFilter.Add(new HierarchyFilterItem {
					Value = hierarchyId,
					ColumnPath = sheetHierarchyList.ElementAt(index).ColumnPath
				});
				index++;
			});
			return hierarchyFilter;
		}

		#endregion

	}

	#endregion

}

