namespace Terrasoft.Core
{

	using System;
	using System.Collections.ObjectModel;
	using Terrasoft.Core;

	#region Class: ModuleInformationImageListSchemaSchema

	/// <exclude/>
	public class ModuleInformationImageListSchemaSchema : Terrasoft.Core.ImageListSchema
	{

		#region Constructors: Public

		public ModuleInformationImageListSchemaSchema(ImageListSchemaManager imageListSchemaManager)
			: base(imageListSchemaManager) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			UId = new Guid("1dedff05-4507-467e-af51-41339b6dcce0");
			RealUId = new Guid("1dedff05-4507-467e-af51-41339b6dcce0");
			Name = "ModuleInformationImageListSchema";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeItems() {
			InitializeLocalizableValues();
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1dedff05-4507-467e-af51-41339b6dcce0"));
		}

		#endregion

	}

	#endregion

}

