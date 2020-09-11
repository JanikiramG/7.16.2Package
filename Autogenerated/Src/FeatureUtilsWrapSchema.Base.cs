namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FeatureUtilsWrapSchema

	/// <exclude/>
	public class FeatureUtilsWrapSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FeatureUtilsWrapSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FeatureUtilsWrapSchema(FeatureUtilsWrapSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("857989eb-d198-4858-9f7a-b2ad3d351897");
			Name = "FeatureUtilsWrap";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,61,79,3,49,12,134,231,171,212,255,96,149,165,39,161,187,189,124,12,20,138,58,32,49,80,49,32,134,92,226,187,70,10,201,201,113,6,84,245,191,227,251,0,81,29,168,99,222,188,126,252,218,246,234,3,99,171,52,194,11,18,169,24,106,46,214,193,215,182,73,164,216,6,63,159,29,230,179,44,69,235,155,19,11,225,213,63,122,177,81,154,3,89,140,226,16,207,5,97,35,32,88,59,21,227,10,54,168,56,17,238,216,186,248,74,170,237,61,111,247,88,171,228,248,206,122,35,196,37,127,182,24,234,229,246,151,217,178,16,243,252,93,220,109,170,156,213,160,59,224,132,7,43,152,148,73,205,161,239,243,19,230,9,121,31,140,196,121,238,89,195,103,89,150,112,109,253,30,201,178,9,210,128,176,190,89,76,104,197,35,242,54,142,234,131,87,149,67,179,220,69,36,89,156,71,221,109,237,18,34,147,12,146,47,202,219,142,60,38,174,66,112,112,190,26,146,254,6,128,14,6,115,232,110,144,101,132,82,211,253,254,153,160,119,118,71,201,142,227,172,232,205,48,110,255,30,212,83,241,248,5,117,211,98,196,0,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("857989eb-d198-4858-9f7a-b2ad3d351897"));
		}

		#endregion

	}

	#endregion

}

