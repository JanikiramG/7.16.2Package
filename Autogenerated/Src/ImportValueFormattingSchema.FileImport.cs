﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportValueFormattingSchema

	/// <exclude/>
	public class ImportValueFormattingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportValueFormattingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportValueFormattingSchema(ImportValueFormattingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7ef40e2c-46f3-4b73-9d6d-c1d44cd695b1");
			Name = "ImportValueFormatting";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,86,93,111,218,58,24,190,206,164,253,7,43,59,210,140,14,51,187,166,64,207,78,11,91,117,74,139,86,84,105,218,166,202,75,12,120,77,156,204,118,152,80,199,127,63,182,99,39,14,73,11,92,32,251,245,251,241,188,31,126,28,134,83,34,114,28,17,176,36,156,99,145,173,36,186,200,216,138,174,11,142,37,205,24,154,209,132,92,165,121,198,229,235,87,79,175,95,5,133,160,108,13,238,118,66,146,244,236,96,143,174,41,251,213,18,94,100,73,66,34,237,76,160,143,132,17,78,163,90,199,15,203,137,146,171,147,55,156,172,149,54,184,72,176,16,67,80,70,191,199,73,65,102,25,79,177,148,202,208,40,230,197,143,132,70,32,210,122,207,169,5,26,116,237,82,129,144,67,176,224,116,139,37,49,78,130,188,220,128,72,159,1,33,185,198,245,16,43,81,233,7,140,65,184,83,191,119,243,249,187,56,14,207,158,183,145,52,245,108,62,125,26,166,233,80,136,99,22,119,57,102,149,213,63,225,102,243,77,217,125,59,98,24,147,136,166,56,153,99,241,56,199,63,51,174,3,190,71,93,22,209,6,243,166,62,101,70,255,237,251,183,101,189,131,55,132,197,101,129,236,222,86,107,70,73,18,11,93,174,76,170,14,146,216,21,204,110,193,127,100,103,10,190,192,148,143,74,104,125,112,137,37,54,210,229,46,39,147,175,223,193,67,148,37,69,202,132,222,31,137,104,250,195,139,72,102,92,199,53,253,181,65,203,94,119,118,25,158,134,195,131,209,3,102,44,2,31,154,42,73,19,104,16,236,95,70,59,39,114,147,189,88,160,45,229,178,192,9,88,218,62,131,143,68,186,53,204,126,252,84,90,96,107,147,185,195,219,10,215,86,245,108,235,176,43,96,190,14,210,62,148,24,246,12,198,128,174,0,172,116,209,244,151,138,39,160,84,235,108,5,93,172,94,207,121,14,56,145,5,103,160,62,242,125,151,30,247,128,36,130,28,24,48,242,187,74,3,66,168,170,75,244,182,97,222,67,75,26,61,10,11,108,239,149,176,93,18,155,189,74,198,185,170,154,85,57,111,228,221,119,195,191,50,141,119,9,89,120,141,10,45,179,59,163,10,173,234,217,137,72,154,40,170,166,117,117,232,197,176,7,247,250,72,124,155,150,174,68,121,75,75,43,56,75,50,44,27,83,172,7,212,31,95,61,38,57,87,70,66,143,227,216,29,163,133,147,157,249,88,91,164,129,22,56,254,76,215,27,9,219,71,215,132,173,229,6,252,93,251,239,183,89,196,75,236,180,123,226,93,232,193,96,0,70,162,72,83,204,119,19,39,48,153,218,6,75,219,107,240,72,118,66,165,150,230,152,19,84,153,14,14,109,71,234,28,167,128,169,39,109,28,150,55,249,70,173,195,201,148,73,42,119,246,114,155,115,52,26,24,229,110,91,191,167,149,181,17,182,237,202,210,138,201,104,224,86,30,89,181,7,108,145,9,169,200,34,34,66,191,126,247,94,32,104,167,160,6,222,7,71,8,194,118,91,245,221,167,177,115,245,100,115,33,111,249,37,89,225,34,145,48,2,227,9,136,144,226,72,48,30,123,254,123,200,196,175,73,164,68,128,174,196,77,145,36,183,124,154,230,114,7,253,224,231,245,132,43,62,249,243,167,70,48,6,76,217,28,114,76,7,179,152,127,241,155,202,104,3,52,139,252,219,152,239,158,155,111,116,145,80,194,154,195,95,121,143,176,34,167,176,254,114,104,104,161,229,213,124,26,14,75,77,7,164,117,181,125,26,110,148,215,82,215,145,24,151,31,150,93,49,218,68,214,77,147,125,255,243,226,244,136,15,207,164,118,122,216,191,194,39,47,242,30,60,121,159,44,251,240,52,36,243,219,155,233,23,135,226,101,213,217,245,237,135,229,33,96,8,45,139,28,190,28,110,180,90,60,216,65,132,213,160,56,204,113,57,236,7,177,158,25,192,142,103,221,202,124,209,254,127,129,237,49,16,29,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ef40e2c-46f3-4b73-9d6d-c1d44cd695b1"));
		}

		#endregion

	}

	#endregion

}

