namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;

	#region Class: ForecastSheetDeleteListener

	[EntityEventListener(SchemaName = "ForecastSheet")]
	public class ForecastSheetDeleteListener : BaseEntityEventListener
	{

		#region Methods: Public

		///<inheritdoc/>
		public override void OnDeleting(object sender, EntityBeforeEventArgs e) {
			base.OnDeleting(sender, e);
			Entity entity = (Entity)sender;
			var forecastSheetId = entity.GetTypedColumnValue<Guid>("Id");
			var referenceSchema = entity.UserConnection.EntitySchemaManager.FindInstanceByUId(
				entity.GetTypedColumnValue<Guid>("ForecastEntityInCellUId"));
			if (referenceSchema == null) {
				return;
			}
			Delete delete = new Delete(entity.UserConnection).From("ForecastRow")
				.Where()
				.Exists(
					new Select(entity.UserConnection)
						.Column("Id").As("Id")
						.From(referenceSchema.Name)
						.Where("RowId").IsEqual("ForecastRow", "Id")
						.And("SheetId").IsEqual(Column.Parameter(forecastSheetId))) as Delete;
			delete.Execute();
		}

		#endregion

	}

	#endregion

}
