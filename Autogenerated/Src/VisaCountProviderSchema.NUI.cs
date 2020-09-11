﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: VisaCountProviderSchema

	/// <exclude/>
	public class VisaCountProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public VisaCountProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public VisaCountProviderSchema(VisaCountProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f7eb7049-3302-470f-a43a-704b62a292d6");
			Name = "VisaCountProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,219,142,211,48,16,125,14,18,255,96,133,151,68,90,229,3,182,203,74,75,111,234,3,80,81,118,121,64,8,121,157,105,107,228,56,197,99,183,84,168,255,206,56,78,210,36,187,11,69,202,203,140,231,204,156,51,151,104,94,0,238,184,0,246,25,140,225,88,174,109,54,46,245,90,110,156,225,86,150,154,253,126,253,42,114,40,245,166,23,97,32,155,188,27,181,79,171,35,90,40,200,175,20,8,15,195,108,14,26,140,20,163,23,224,67,44,217,228,121,99,96,227,139,142,21,71,188,102,15,18,249,184,116,218,46,77,185,151,57,24,10,161,111,231,30,149,20,76,248,160,167,49,215,108,241,161,180,114,45,69,37,160,3,245,82,60,190,45,51,147,160,114,170,179,52,114,207,45,52,207,187,96,178,137,172,180,112,115,188,65,107,136,235,21,43,31,127,144,192,91,182,227,134,58,103,193,224,168,139,184,71,48,212,62,29,154,192,190,187,158,61,106,235,131,206,3,133,33,35,10,166,82,78,216,210,120,94,149,208,150,86,144,253,68,112,114,17,207,180,154,100,20,217,173,196,108,5,118,217,190,36,157,160,138,226,233,223,60,223,131,221,150,249,75,20,165,182,108,14,182,98,153,52,133,231,78,230,12,143,120,151,23,82,223,107,105,23,57,123,203,18,239,78,43,82,103,26,95,227,126,92,252,173,226,21,237,185,97,194,39,93,129,223,51,130,107,56,176,96,36,131,102,167,126,27,93,161,147,153,211,34,11,84,226,135,131,239,94,124,197,98,74,154,166,217,68,162,149,154,192,105,149,63,202,102,166,44,218,176,198,249,101,11,6,200,75,190,143,7,218,106,143,205,22,56,253,233,184,74,66,149,172,109,103,210,167,158,54,73,238,116,158,196,11,28,115,45,136,239,95,51,172,185,66,232,3,87,150,91,135,161,176,78,194,75,116,129,248,74,103,163,138,248,135,60,141,178,179,182,5,206,164,230,234,98,86,41,227,88,215,14,163,241,35,55,128,78,249,169,116,102,148,77,127,129,112,22,86,130,43,110,110,40,236,54,9,91,22,25,176,206,232,26,213,95,188,122,143,194,54,251,85,250,4,212,209,156,12,108,247,169,134,135,152,108,90,236,236,241,217,36,245,174,80,146,169,182,210,74,192,186,103,131,68,218,41,245,108,130,125,73,139,219,191,152,255,191,184,179,155,250,51,248,123,68,131,233,249,179,232,255,73,210,238,109,244,131,235,219,120,254,102,79,225,135,217,245,157,254,0,21,112,135,249,243,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f7eb7049-3302-470f-a43a-704b62a292d6"));
		}

		#endregion

	}

	#endregion

}

