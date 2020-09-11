namespace Terrasoft.Core
{

	using System;
	using System.Collections.ObjectModel;
	using Terrasoft.Core;

	#region Class: DemoButtonsSchema

	/// <exclude/>
	public class DemoButtonsSchema : Terrasoft.Core.ImageListSchema
	{

		#region Constructors: Public

		public DemoButtonsSchema(ImageListSchemaManager imageListSchemaManager)
			: base(imageListSchemaManager) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			UId = new Guid("925c9b4b-423e-4ba2-945f-30781c61a6d5");
			RealUId = new Guid("925c9b4b-423e-4ba2-945f-30781c61a6d5");
			Name = "DemoButtons";
			CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
		}

		protected override void InitializeItems() {
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("98fb635a-69a6-48cb-b001-31db916c71da"),
				Name = "BuyNowLeft",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")});
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("06a9d303-0e51-40b2-ad27-dcd6b2a39326"),
				Name = "BuyNowCenter",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")});
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("88b315a0-a067-4b07-9ced-a206de0a90a5"),
				Name = "BuyNowRight",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")});
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("d2add44e-6df0-4f75-a5d4-477f2722ab4a"),
				Name = "LiveChatLeft",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")});
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("06a7e722-6b10-4f4b-907f-a675d74c97cb"),
				Name = "LiveChatCenter",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")});
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("730455f7-fec2-4e26-bcb9-911f29b8dc18"),
				Name = "LiveChatRight",
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")});
			InitializeLocalizableValues();
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("925c9b4b-423e-4ba2-945f-30781c61a6d5"));
		}

		#endregion

	}

	#endregion

}

