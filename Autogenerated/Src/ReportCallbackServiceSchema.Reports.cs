﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportCallbackServiceSchema

	/// <exclude/>
	public class ReportCallbackServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportCallbackServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportCallbackServiceSchema(ReportCallbackServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a5244969-4616-4788-a99f-f6017305531d");
			Name = "ReportCallbackService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,77,111,219,56,16,61,187,64,255,3,87,221,131,12,4,244,221,141,3,164,222,77,224,69,147,22,181,23,61,4,61,208,210,88,38,66,145,42,73,121,225,13,242,223,59,67,74,150,109,200,118,122,48,44,14,231,243,205,155,161,22,37,184,74,100,192,22,96,173,112,102,229,249,212,232,149,44,106,43,188,52,250,253,187,151,247,239,6,181,147,186,96,243,173,243,80,126,60,58,243,57,216,141,204,224,193,228,160,206,94,242,239,176,60,175,112,155,121,185,9,113,59,189,66,153,165,80,227,241,212,148,165,209,252,179,41,10,20,119,247,119,82,1,166,188,1,235,193,242,169,146,160,61,95,8,247,220,169,236,215,70,78,250,111,44,156,146,243,59,145,121,99,37,184,62,13,172,170,243,139,247,31,44,20,88,1,155,42,225,220,152,125,131,202,88,63,21,74,45,69,246,220,148,27,20,159,154,3,102,239,45,70,248,65,178,91,87,61,130,71,127,21,226,176,148,74,250,237,55,248,89,75,11,37,22,230,210,253,3,129,198,38,236,130,9,105,241,70,144,15,41,72,85,47,149,204,88,70,9,246,231,199,198,236,147,112,208,158,94,66,190,187,202,190,90,83,33,220,136,199,152,190,61,100,30,242,168,50,26,141,216,181,171,203,82,216,237,77,43,184,7,239,152,95,3,83,216,60,176,204,172,152,13,81,89,1,26,34,209,248,206,122,180,111,94,181,238,217,70,90,95,11,197,102,200,0,70,63,34,230,96,80,128,167,166,12,94,223,18,223,129,206,79,196,103,25,226,167,224,183,82,137,208,221,239,124,76,119,46,230,49,80,131,237,177,184,55,243,15,120,23,241,61,4,27,217,225,188,173,137,128,4,119,104,221,153,90,103,90,122,41,148,252,31,28,19,76,195,127,76,162,189,208,216,69,44,155,64,184,118,0,44,179,176,154,36,189,189,79,70,55,145,26,167,112,136,236,233,181,77,135,77,113,212,160,9,181,233,65,104,129,61,231,216,131,207,161,251,105,114,12,91,50,12,56,12,78,160,53,137,147,20,103,112,75,142,174,47,1,127,147,14,223,2,237,3,248,181,201,3,137,105,237,196,169,196,62,135,3,251,215,129,61,14,68,123,133,232,52,21,217,26,242,190,219,244,190,150,57,243,248,53,203,91,48,54,194,178,44,88,204,112,229,209,196,86,21,182,85,35,155,136,110,113,19,82,184,61,33,170,32,202,177,58,50,125,138,46,249,194,204,189,197,5,148,14,127,124,60,114,30,146,155,236,71,18,238,100,21,209,184,51,228,211,53,100,207,183,182,168,105,105,60,214,74,165,26,31,7,179,74,59,157,97,211,40,11,190,182,122,47,234,239,129,125,137,194,212,195,56,175,53,38,207,180,241,114,213,64,193,196,210,212,190,103,122,9,157,203,35,28,36,149,176,162,100,84,220,36,201,194,195,225,26,76,146,155,5,6,109,188,224,156,175,240,105,97,157,74,8,194,175,71,193,65,240,247,244,165,218,49,176,219,225,131,39,124,18,102,122,99,158,33,13,120,197,210,177,53,201,215,47,243,69,114,21,132,159,76,190,157,251,173,162,13,142,250,15,224,28,14,202,78,202,191,91,81,85,144,95,53,163,241,179,6,231,239,140,45,133,63,48,136,34,254,143,51,186,85,117,21,174,12,56,175,27,222,129,118,148,219,125,182,49,72,221,71,130,123,155,118,207,106,139,14,59,4,171,37,247,161,244,12,141,14,173,135,29,123,9,230,195,219,25,129,117,228,120,150,119,22,245,169,209,156,92,24,206,190,80,77,38,114,197,210,63,250,87,16,167,191,6,195,163,58,174,78,230,50,108,1,162,93,200,255,182,214,216,244,207,132,8,246,38,66,119,92,102,203,109,164,247,236,47,172,239,165,175,132,87,182,198,81,71,191,108,9,160,233,153,243,188,221,170,175,167,103,51,74,15,133,175,191,0,187,93,129,145,19,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a5244969-4616-4788-a99f-f6017305531d"));
		}

		#endregion

	}

	#endregion

}
