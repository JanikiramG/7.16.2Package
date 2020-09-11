namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Core.Factories;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;

	#region Class: CommonEntityStageManager

	/// <summary>
	/// Common configurable entity stage manager.
	/// </summary>
	/// <seealso cref="Configuration.EntityStageManager
	/// {EntityInHistorycalStage, CommonStageData, ICommonEntityInStageRepository{Configuration.EntityInHistoricalStage}}" />
	[DefaultBinding(typeof(IEntityStageManagerV2))]
	public class CommonEntityStageManager : EntityStageManager<EntityInHistoricalStage, CommonStageData,
		ICommonEntityInStageRepository<EntityInHistoricalStage>>
	{
		#region Constructors: Public

		public CommonEntityStageManager(UserConnection userConnection,
				IGetRepository<CommonStageData> entityStageRepository,
				ICommonEntityInStageRepository<EntityInHistoricalStage> entityInStageRepository,
				StageHistorySetting stageHistorySetting)
			: base(userConnection, entityStageRepository, entityInStageRepository, stageHistorySetting) {
		}

		#endregion

		#region Methods: Private

		private bool HasHistoricalColumn() {
			var entitySchema = UserConnection.EntitySchemaManager.FindInstanceByName(
				StageHistorySetting.StageHistorySchemaName);
			return entitySchema?.Columns.FindByName(StageHistorySetting.StageHistoryHistoricalColumnName) != null;
		}

		#endregion

		#region Methods: Protected

		protected override void ProcessPreviousStages(Entity entity, CommonStageData oldStageData, 
				CommonStageData newStageData) {
			base.ProcessPreviousStages(entity, oldStageData, newStageData);
			if (!HasHistoricalColumn()) {
				return;
			}
			Guid entityId = entity.PrimaryColumnValue;
			var historicalStages = EntityInStageRepository.GetHistoricalEntityInStage(entityId, newStageData.Number);
			EntityInStageRepository.BulkUpdate(historicalStages, new Dictionary<string, object> {
				{StageHistorySetting.StageHistoryHistoricalColumnName, true}
			});
		}

		protected override void ProcessIntermediateStages(Entity entity, CommonStageData oldStageData, 
				CommonStageData newStageData) {
			if (newStageData.IsSuccessful && newStageData.IsEnd || !newStageData.IsEnd) {
				base.ProcessIntermediateStages(entity, oldStageData, newStageData);
			}
		}

		#endregion
	} 

	#endregion

}
