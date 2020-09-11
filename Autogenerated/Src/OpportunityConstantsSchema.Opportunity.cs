namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityConstantsSchema

	/// <exclude/>
	public class OpportunityConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityConstantsSchema(OpportunityConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ff91c21e-dcda-4052-875f-3134d07a6a12");
			Name = "OpportunityConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,77,75,196,48,16,134,207,91,232,127,8,123,210,67,182,233,71,210,6,63,64,170,21,65,16,84,240,156,230,99,169,180,73,73,82,150,34,254,119,227,174,136,187,23,247,176,16,134,48,243,206,59,15,195,76,174,211,107,240,50,59,47,135,139,56,138,35,205,6,233,70,198,37,120,149,214,50,103,148,95,213,70,171,110,61,89,230,59,163,227,232,35,142,22,227,212,246,29,7,206,135,28,7,188,103,206,129,167,113,52,214,79,186,243,115,232,8,37,237,93,144,126,203,23,73,146,128,75,55,13,3,179,243,245,46,1,234,222,56,41,128,149,239,146,251,240,9,29,107,185,250,85,39,127,229,251,243,172,100,194,232,126,6,247,83,39,246,230,110,45,159,127,28,31,4,184,2,90,110,182,178,179,101,153,147,6,23,205,45,188,203,10,4,11,210,84,176,170,203,26,82,68,72,157,163,155,166,193,116,121,190,221,194,63,192,214,76,39,6,222,57,30,0,83,214,170,172,200,57,84,28,5,96,204,21,172,100,86,65,46,90,66,56,205,80,213,162,99,128,55,70,159,142,245,205,232,3,76,130,4,206,83,196,33,110,37,129,66,165,41,164,101,218,66,132,82,65,144,164,121,197,201,49,152,33,250,211,113,62,6,183,3,80,70,25,83,66,73,152,101,69,6,11,21,66,197,5,134,25,147,121,75,49,38,162,220,29,192,226,51,142,194,251,2,132,38,205,159,29,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff91c21e-dcda-4052-875f-3134d07a6a12"));
		}

		#endregion

	}

	#endregion

}

