namespace Terrasoft.Configuration.ForecastV2
{
	using Newtonsoft.Json;
	using System;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Nui.ServiceModel.DataContract;

	#region Interface: IForecastColumnSettingsMapper

	public interface IForecastColumnSettingsMapper
	{

		#region Methods: Public

		/// <summary>
		/// Gets the forecast column settings data from forecast column.
		/// </summary>
		/// <param name="userConnection">User connection instance.</param>
		/// <param name="column">Forecast column.</param>
		/// <returns>Column settings data</returns>
		ColumnSettingsData GetForecastColumnSettingsData(UserConnection userConnection,
			ForecastColumn column);

		#endregion

	}

	#endregion

	#region Class: IForecastColumnSettingsMapper

	[DefaultBinding(typeof(IForecastColumnSettingsMapper))]
	public class ForecastColumnSettingsMapper : IForecastColumnSettingsMapper
	{

		#region Methods: Private

		private string GetColumnName(Core.Entities.EntitySchema entitySchema, Guid columnUId) {
			return entitySchema.Columns.FirstOrDefault(c => c.UId == columnUId)?.Name;
		}

		#endregion

		#region Methods: Protected

		protected virtual ColumnSettingsData FillSettings(UserConnection userConnection, ForecastColumn column) {
			ColumnSetting deserialized = Json.Deserialize<ColumnSetting>(column.Settings);
			Core.Entities.EntitySchema schema = userConnection.EntitySchemaManager.GetInstanceByUId(deserialized.SourceUId);
			ColumnSettingsData settings = new ColumnSettingsData {
				SourceEntityName = schema.Name,
				ReferenceColumnName = deserialized.RefColumnPath ?? GetColumnName(schema, deserialized.RefColumnId),
				PeriodColumnName = deserialized.PeriodColumnPath ?? GetColumnName(schema, deserialized.PeriodColumnId),
				FuncColumnName = deserialized.FuncColumnPath ?? GetColumnName(schema, deserialized.FuncColumnId),
				FuncCode = deserialized.FuncCode,
				PercentOperand = deserialized.PercentOperand,
				FilterData = deserialized.FilterData.IsNotNullOrEmpty() ?
					Json.Deserialize<Filters>(deserialized.FilterData) : null
			};
			return settings;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Gets the forecast column settings data from forecast column.
		/// </summary>
		/// <param name="userConnection">User connection instance.</param>
		/// <param name="column">Forecast column.</param>
		/// <returns>Column settings data</returns>
		public ColumnSettingsData GetForecastColumnSettingsData(UserConnection userConnection,
				ForecastColumn column) {
			column.CheckArgumentNull(nameof(column));
			if (column.Settings.IsNullOrWhiteSpace()) {
				return null;
			}
			ColumnSettingsData settings = FillSettings(userConnection, column);
			return settings;
		}

		#endregion
	}

	#endregion

	#region Class: ColumnSettingsData

	/// <summary>
	/// Editable column settings.
	/// </summary>
	public class EditableSettings
	{
		/// <summary>
		/// Gets or sets is group edit flag.
		/// </summary>
		[JsonProperty("isGroupEdit")]
		public bool IsGroupEdit { get; set; }
	}

	#endregion

	#region Class: ColumnSettingsData

	/// <summary>
	/// Represents column settings data.
	/// </summary>
	public partial class ColumnSettingsData
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the name of the source entity.
		/// </summary>
		/// <value>
		/// The name of the source entity.
		/// </value>
		public string SourceEntityName { get; set; }

		/// <summary>
		/// Gets or sets the name of the reference entity column.
		/// </summary>
		/// <value>
		/// The name of the reference column.
		/// </value>
		public string ReferenceColumnName { get; set; }

		/// <summary>
		/// Gets or sets the name of the period column.
		/// </summary>
		/// <value>
		/// The name of the period column.
		/// </value>
		public string PeriodColumnName { get; set; }

		/// <summary>
		/// Gets or sets the name of the function column.
		/// </summary>
		/// <value>
		/// The name of the function column.
		/// </value>
		public string FuncColumnName { get; set; }

		/// <summary>
		/// Gets or sets the filter data.
		/// </summary>
		/// <value>
		/// The filter data.
		/// </value>
		public Filters FilterData { get; set; }

		/// <summary>
		/// Gets or sets the function code.
		/// </summary>
		/// <value>
		/// The function code.
		/// </value>
		public string FuncCode { get; set; }

		/// <summary>
		/// Gets or sets the percent operation operand.
		/// </summary>
		/// <value>
		/// Percent operand.
		/// </value>
		public string PercentOperand { get; set; }

		#endregion

	}

	#endregion


	#region Class: ColumnSetting

	/// <summary>
	/// Represents column settings.
	/// </summary>
	public partial class ColumnSetting
	{
		/// <summary>
		/// Unique identifier of calculated entity.
		/// </summary>
		[JsonProperty("sourceUId")]
		public Guid SourceUId { get; set; }

		/// <summary>
		/// Unique identifier of reference column.
		/// </summary>
		[JsonProperty("refColumnId")]
		public Guid RefColumnId { get; set; }

		/// <summary>
		/// Gets or sets the reference column path.
		/// </summary>
		[JsonProperty("refColumnPath")]
		public string RefColumnPath { get; set; }

		/// <summary>
		/// Unique identifier of period column.
		/// </summary>
		[JsonProperty("periodColumnId")]
		public Guid PeriodColumnId { get; set; }

		/// <summary>
		/// Path of period column.
		/// </summary>
		[JsonProperty("periodColumnPath")]
		public string PeriodColumnPath { get; set; }

		/// <summary>
		/// Filter data json string.
		/// </summary>
		[JsonProperty("filter")]
		public string FilterData { get; set; }

		/// <summary>
		/// Unique identifier of calculated function column.
		/// </summary>
		[JsonProperty("funcColumnId")]
		public Guid FuncColumnId { get; set; }

		/// <summary>
		/// Gets or sets the function column path.
		/// </summary>
		[JsonProperty("funcColumnPath")]
		public string FuncColumnPath { get; set; }

		/// <summary>
		/// Calculation function code.
		/// </summary>
		[JsonProperty("funcCode")]
		public string FuncCode { get; set; }

		/// <summary>
		/// Gets or sets the percent operation operand.
		/// </summary>
		[JsonProperty("percentOperand")]
		public string PercentOperand { get; set; }

	}

	#endregion

}

