﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DocumentNotificationProviderSchema

	/// <exclude/>
	public class DocumentNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DocumentNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DocumentNotificationProviderSchema(DocumentNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9278ff4-42d2-4749-a9fd-a9f59f42dd6d");
			Name = "DocumentNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,203,110,219,48,16,60,171,64,255,129,80,46,34,16,240,3,226,52,64,234,23,92,164,77,16,59,232,161,40,10,134,90,219,44,36,210,229,195,173,81,228,223,187,20,37,69,82,28,183,5,236,131,150,59,187,179,195,89,42,94,130,221,113,1,100,5,198,112,171,215,142,141,181,90,203,141,55,220,73,173,200,239,183,111,18,111,165,218,244,50,12,176,201,251,81,123,180,60,88,7,37,198,139,2,68,128,89,54,7,5,70,138,209,43,240,33,22,191,49,114,102,96,19,154,142,11,110,237,5,153,104,225,75,80,238,147,118,114,45,69,69,232,206,232,189,204,193,96,54,254,118,254,177,144,130,136,144,127,50,253,130,44,142,133,9,214,8,19,182,157,103,18,138,28,91,223,25,185,231,14,194,81,248,239,226,39,153,200,106,60,110,14,151,214,25,164,127,78,244,227,119,156,249,138,236,184,65,49,29,24,59,234,34,30,44,24,84,84,69,93,200,55,223,251,30,53,13,206,64,229,145,66,27,105,180,64,53,157,241,194,105,19,120,85,3,183,180,226,248,167,6,207,254,137,50,173,238,57,73,220,86,90,182,4,119,215,158,100,157,164,138,237,211,223,41,127,4,183,213,249,107,108,165,114,100,14,110,172,189,114,89,211,120,238,101,78,236,193,94,231,165,84,15,74,186,69,78,222,145,44,132,105,69,234,153,198,151,180,159,151,126,173,120,37,19,148,123,37,75,32,121,208,29,193,77,224,101,129,220,67,56,108,144,123,110,136,8,116,150,16,252,139,88,5,63,73,252,200,6,55,70,131,203,125,169,178,153,87,130,197,33,210,123,64,54,57,106,155,158,147,20,25,81,202,38,210,58,169,16,79,171,22,9,155,25,93,118,51,155,248,13,172,221,173,71,94,31,180,84,89,186,236,204,150,82,118,171,6,213,145,137,227,34,140,77,217,194,78,127,120,94,12,64,253,164,186,203,2,249,215,29,26,183,28,171,190,244,149,53,250,213,91,64,61,92,93,242,243,22,12,52,248,160,115,133,185,1,107,111,77,68,70,165,88,107,166,44,220,12,91,105,164,185,199,123,224,69,64,101,148,54,21,175,85,158,165,11,123,15,188,219,255,69,149,53,47,44,244,65,125,1,210,197,73,124,223,62,148,18,110,235,203,142,118,8,6,53,96,125,17,156,208,241,5,155,254,2,129,55,181,20,188,224,230,18,211,174,178,184,19,137,1,231,141,170,81,253,53,169,93,31,119,47,24,191,21,220,182,238,175,225,49,135,77,203,157,59,28,45,82,251,19,139,76,149,147,78,130,173,77,58,40,164,124,81,28,45,176,215,184,102,253,253,254,255,247,225,57,140,250,12,158,189,100,176,46,97,15,251,79,32,237,46,98,63,185,222,199,227,47,204,83,124,241,187,177,167,63,231,225,184,18,191,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9278ff4-42d2-4749-a9fd-a9f59f42dd6d"));
		}

		#endregion

	}

	#endregion

}

