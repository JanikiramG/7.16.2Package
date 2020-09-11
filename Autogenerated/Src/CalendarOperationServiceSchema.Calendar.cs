﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarOperationServiceSchema

	/// <exclude/>
	public class CalendarOperationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarOperationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarOperationServiceSchema(CalendarOperationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7b35de8e-8c34-46d3-9585-8cb88343bd80");
			Name = "CalendarOperationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,75,111,218,64,16,128,207,68,202,127,24,57,23,144,144,185,231,129,148,144,54,162,42,73,20,72,115,64,61,44,246,64,86,241,171,187,107,82,55,202,127,239,236,218,107,99,67,73,35,165,161,149,42,33,176,119,231,181,51,223,140,77,196,66,148,9,243,16,38,40,4,147,241,92,185,131,56,154,243,69,42,152,226,113,228,14,88,128,145,207,132,220,223,123,218,223,107,165,146,71,11,24,103,82,97,120,212,184,39,205,32,64,79,171,73,247,2,35,20,220,91,147,25,163,88,114,15,71,177,143,193,214,77,247,14,103,219,5,78,201,213,210,68,185,38,119,147,70,138,135,168,229,57,11,248,143,134,84,117,88,114,66,97,135,161,217,165,253,233,213,76,198,1,42,252,170,111,10,119,148,17,37,152,167,204,218,169,76,46,81,145,78,66,70,103,60,224,42,187,193,111,41,23,24,98,164,100,123,245,70,199,9,39,240,130,138,150,114,139,5,191,163,157,36,233,44,224,30,120,1,147,18,108,5,174,18,204,107,82,68,5,135,112,198,36,22,119,164,165,235,67,159,214,129,192,5,137,193,8,213,125,236,203,67,184,54,230,138,221,94,175,7,199,50,13,67,38,178,190,93,56,245,125,208,9,131,52,226,10,150,44,72,17,84,12,62,83,8,179,12,188,34,4,224,209,60,22,97,78,70,105,172,215,180,118,156,48,193,66,136,8,174,19,199,234,14,125,167,63,40,237,248,116,112,62,231,40,220,227,158,145,222,172,172,3,112,250,231,244,189,93,78,199,126,75,161,59,253,137,61,197,118,5,115,68,167,255,69,255,172,75,10,84,169,136,100,255,6,101,26,40,147,6,18,178,171,90,108,90,86,99,21,142,214,148,120,26,70,203,248,1,219,121,246,169,250,206,245,213,120,226,116,65,87,24,165,250,104,18,72,235,36,58,66,41,217,2,243,37,247,147,140,163,46,156,197,126,54,86,89,128,53,145,114,213,189,19,44,73,208,239,106,119,45,10,48,161,110,195,237,70,13,83,22,42,157,76,147,36,170,121,251,34,229,62,84,21,234,86,187,250,204,93,152,20,121,5,155,224,46,33,80,0,210,129,39,19,195,146,234,153,42,67,53,5,16,225,99,73,236,109,190,218,94,117,112,43,81,80,202,162,124,78,116,142,140,137,60,179,214,138,171,35,203,253,87,110,115,151,70,252,121,199,36,87,28,255,135,119,151,240,14,109,25,142,203,171,115,150,245,203,26,255,97,154,223,158,93,243,204,212,160,150,148,250,44,147,53,108,31,17,31,128,158,112,73,160,203,250,94,35,88,39,206,233,143,21,19,57,79,191,100,110,176,26,120,147,186,191,31,175,21,140,100,241,92,181,86,202,226,220,81,5,94,152,155,250,162,163,205,218,39,178,161,74,88,75,117,172,54,248,106,23,104,41,145,21,84,190,197,144,109,217,0,92,237,146,172,88,100,107,39,43,227,207,149,158,233,148,202,187,135,246,135,239,30,38,218,26,148,173,82,25,172,54,79,0,11,197,213,230,176,130,249,214,206,251,224,53,3,252,109,208,255,103,7,238,111,119,196,43,135,177,65,108,101,228,190,83,115,216,86,216,17,250,150,250,3,10,38,127,73,111,188,178,15,244,27,127,227,133,125,74,137,99,53,110,54,254,61,216,84,161,67,168,253,153,107,108,219,9,85,185,191,22,49,129,170,56,54,99,88,239,83,179,82,103,190,18,172,181,97,126,128,17,134,51,20,237,75,106,44,77,185,142,214,201,73,179,199,25,126,230,82,53,232,49,147,234,9,22,168,142,64,234,47,155,193,122,10,55,39,150,22,159,127,2,1,76,22,101,225,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b35de8e-8c34-46d3-9585-8cb88343bd80"));
		}

		#endregion

	}

	#endregion

}
