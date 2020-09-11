﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GuidColumnProcessorSchema

	/// <exclude/>
	public class GuidColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GuidColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GuidColumnProcessorSchema(GuidColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1b4d6336-7126-4448-a08f-ebdcc4304edb");
			Name = "GuidColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,77,111,219,48,12,61,167,64,255,3,145,93,28,32,176,239,249,42,182,20,29,114,88,17,108,73,47,195,14,138,77,39,2,108,201,163,164,2,65,144,255,62,74,182,187,216,75,122,25,122,113,100,230,241,61,242,81,180,18,37,154,74,164,8,27,36,18,70,231,54,94,106,149,203,189,35,97,165,86,241,147,44,112,85,86,154,236,253,221,233,254,110,224,140,84,123,248,113,52,22,203,233,219,251,101,54,225,173,120,252,36,82,171,73,162,97,4,99,62,17,238,89,3,150,133,48,102,2,95,157,204,150,186,112,165,90,147,78,209,24,77,1,150,36,9,204,164,58,32,73,155,233,20,82,194,124,62,124,214,106,141,100,36,23,162,108,47,237,180,249,142,198,21,246,60,76,22,45,129,113,101,41,232,216,190,127,86,32,149,177,66,113,239,58,7,123,144,6,82,95,7,240,129,216,20,173,140,220,21,8,185,38,168,106,98,223,145,47,18,210,32,7,175,162,112,104,226,86,33,185,144,248,249,136,185,224,10,190,72,149,113,90,100,143,21,234,60,90,245,10,29,141,225,153,71,0,115,80,252,195,128,43,30,140,70,191,130,13,149,219,21,50,109,138,188,130,131,9,188,231,201,204,167,60,44,198,208,175,129,169,79,65,224,239,60,184,119,75,206,207,138,199,178,14,186,53,226,191,71,241,207,44,66,96,73,40,44,154,238,68,216,49,70,34,54,34,87,58,102,202,248,141,51,233,147,206,42,65,162,12,198,206,135,206,32,113,91,10,83,127,171,135,139,45,191,243,24,219,64,60,75,2,58,36,55,70,95,17,140,182,29,26,232,178,142,120,2,59,97,48,234,135,253,222,12,206,141,199,168,178,218,230,174,231,172,81,33,89,222,141,137,63,91,206,197,236,67,77,127,20,86,212,87,184,246,218,41,249,155,207,50,99,62,153,75,164,27,222,86,109,117,160,95,121,189,25,95,47,133,231,123,241,116,27,102,219,174,50,152,47,186,177,216,195,250,168,233,251,182,124,67,123,208,217,71,120,114,163,141,7,127,251,57,96,67,145,81,253,233,171,169,66,164,217,253,112,110,38,59,240,67,143,59,105,151,160,105,192,200,28,194,114,199,27,58,174,5,153,14,38,14,207,49,104,103,219,15,76,32,195,172,166,104,133,6,132,214,145,234,253,93,11,156,195,179,1,40,87,20,211,219,183,174,142,118,131,231,63,115,49,22,83,12,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b4d6336-7126-4448-a08f-ebdcc4304edb"));
		}

		#endregion

	}

	#endregion

}
