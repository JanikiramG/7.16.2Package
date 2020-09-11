namespace Terrasoft.Core
{

	using System;
	using System.Collections.ObjectModel;
	using Terrasoft.Core;

	#region Class: ContactCardImageListSchema

	/// <exclude/>
	public class ContactCardImageListSchema : Terrasoft.Core.ImageListSchema
	{

		#region Constructors: Public

		public ContactCardImageListSchema(ImageListSchemaManager imageListSchemaManager)
			: base(imageListSchemaManager) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			UId = new Guid("d3cf6e63-3322-49e5-8b11-049812be5090");
			RealUId = new Guid("d3cf6e63-3322-49e5-8b11-049812be5090");
			Name = "ContactCardImageList";
			CreatedInPackageId = new Guid("a33acecb-9d82-43e3-80ef-44e4bc6c4986");
		}

		protected override void InitializeItems() {
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("8fe7c97d-0586-4c29-862d-a649e1dd7623"),
				Name = "arrow_left",
				CreatedInPackageId = new Guid("a33acecb-9d82-43e3-80ef-44e4bc6c4986")});
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("7068bb49-6efa-41d1-8cbe-49e1b0ab2b30"),
				Name = "arrow_right",
				CreatedInPackageId = new Guid("a33acecb-9d82-43e3-80ef-44e4bc6c4986")});
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("d3181b9c-6ffc-4d1f-b35e-755a5df5666b"),
				Name = "contact_photo_example",
				CreatedInPackageId = new Guid("a33acecb-9d82-43e3-80ef-44e4bc6c4986")});
			InitializeLocalizableValues();
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3cf6e63-3322-49e5-8b11-049812be5090"));
		}

		#endregion

	}

	#endregion

}

