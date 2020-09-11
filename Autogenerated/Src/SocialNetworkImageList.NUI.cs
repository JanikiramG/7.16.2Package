namespace Terrasoft.Core
{

	using System;
	using System.Collections.ObjectModel;
	using Terrasoft.Core;

	#region Class: SocialNetworkImageListSchema

	/// <exclude/>
	public class SocialNetworkImageListSchema : Terrasoft.Core.ImageListSchema
	{

		#region Constructors: Public

		public SocialNetworkImageListSchema(ImageListSchemaManager imageListSchemaManager)
			: base(imageListSchemaManager) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			UId = new Guid("098f260a-4fc4-4f68-8a1c-ed9398044397");
			RealUId = new Guid("098f260a-4fc4-4f68-8a1c-ed9398044397");
			Name = "SocialNetworkImageList";
			CreatedInPackageId = new Guid("9781bf7b-9e0e-4000-8053-2be012e16476");
		}

		protected override void InitializeItems() {
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("285583b5-635a-4722-9a20-a1a3b1ede5c2"),
				Name = "facebook",
				CreatedInPackageId = new Guid("9781bf7b-9e0e-4000-8053-2be012e16476")});
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("62ec5e85-443c-418b-a60f-1b2fb2995dc3"),
				Name = "twitter",
				CreatedInPackageId = new Guid("9781bf7b-9e0e-4000-8053-2be012e16476")});
			Items.Add(new ImageListSchemaItem() {
				UId = new Guid("d3c00d8c-32f8-42b3-87ca-4849abdd28ef"),
				Name = "linkedIn",
				CreatedInPackageId = new Guid("9781bf7b-9e0e-4000-8053-2be012e16476")});
			InitializeLocalizableValues();
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("098f260a-4fc4-4f68-8a1c-ed9398044397"));
		}

		#endregion

	}

	#endregion

}

