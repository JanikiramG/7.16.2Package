namespace Terrasoft.Core
{

	using System;
	using System.Collections.ObjectModel;
	using Terrasoft.Core;

	#region Class: PeriodImageListSchemaSchema

	/// <exclude/>
	public class PeriodImageListSchemaSchema : Terrasoft.Core.ImageListSchema
	{

		#region Constructors: Public

		public PeriodImageListSchemaSchema(ImageListSchemaManager imageListSchemaManager)
			: base(imageListSchemaManager) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			UId = new Guid("7b4b2ab8-27bf-499c-a8f8-c348384a6bd6");
			RealUId = new Guid("7b4b2ab8-27bf-499c-a8f8-c348384a6bd6");
			Name = "PeriodImageListSchema";
			CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
		}

		protected override void InitializeItems() {
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("ceeaa064-ff61-470b-8fac-088d723602d5"),
				Name = "OneDayItem",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")});
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("0399ffc4-0973-4e91-9637-99137e5b2e31"),
				Name = "OneWeekItem",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")});
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("d1302cce-bc55-4d86-a773-74ce01b492d3"),
				Name = "OneMonthItem",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")});
			InitializeLocalizableValues();
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b4b2ab8-27bf-499c-a8f8-c348384a6bd6"));
		}

		#endregion

	}

	#endregion

}

