namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PriceListPickerRebinderSchema

	/// <exclude/>
	public class PriceListPickerRebinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PriceListPickerRebinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PriceListPickerRebinderSchema(PriceListPickerRebinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("58d4987a-d23e-4bb9-a16c-5a1bd52bc088");
			Name = "PriceListPickerRebinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ae20eb0-a56b-4e38-9555-e43d9bbc10d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,80,77,107,194,64,16,61,71,240,63,12,244,98,161,36,119,21,161,74,11,133,150,6,91,232,121,179,25,227,80,179,27,102,55,161,34,254,247,78,178,73,209,96,79,203,236,251,152,55,207,168,18,93,165,52,194,39,50,43,103,119,62,222,88,179,163,162,102,229,201,154,233,228,52,157,68,181,35,83,92,81,24,227,103,165,189,101,66,183,184,193,248,194,76,88,101,105,141,160,130,223,49,22,98,7,155,131,114,110,14,41,147,198,87,114,62,37,253,141,188,197,140,76,142,220,81,147,36,129,165,171,203,82,241,113,213,207,47,35,1,232,214,7,184,215,197,131,44,185,208,85,117,118,32,221,51,255,89,8,115,120,172,170,167,6,141,111,65,52,200,107,229,80,212,167,46,203,95,238,55,244,123,155,183,201,59,215,0,246,27,108,35,103,83,142,208,88,202,225,221,136,227,135,87,236,103,131,181,52,234,241,199,131,14,239,61,180,157,70,81,38,155,226,11,250,0,47,58,180,107,42,116,124,140,183,184,150,188,203,113,13,15,144,138,80,66,187,61,85,35,108,53,11,70,231,254,16,52,121,184,165,155,195,239,245,231,249,23,74,109,84,201,14,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("58d4987a-d23e-4bb9-a16c-5a1bd52bc088"));
		}

		#endregion

	}

	#endregion

}

