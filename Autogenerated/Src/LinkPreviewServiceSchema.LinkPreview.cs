﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LinkPreviewServiceSchema

	/// <exclude/>
	public class LinkPreviewServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LinkPreviewServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LinkPreviewServiceSchema(LinkPreviewServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2f90e9aa-9e05-4910-b594-3ce033df149a");
			Name = "LinkPreviewService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,75,111,218,64,16,62,27,137,255,48,34,23,35,33,251,206,75,74,104,83,165,202,3,65,162,28,80,15,139,61,144,85,108,175,187,187,38,117,35,254,123,103,253,32,139,99,146,168,151,149,102,246,251,230,61,3,153,226,201,22,150,185,210,24,143,186,29,91,244,22,89,162,121,140,222,18,37,103,17,255,203,52,23,73,19,68,159,59,30,224,141,8,49,250,232,207,59,15,52,223,125,106,194,123,196,117,243,159,84,132,81,138,168,75,205,52,30,254,239,81,74,166,196,70,123,51,33,209,187,100,129,22,146,163,106,1,24,27,51,17,199,133,247,110,39,97,49,170,148,5,120,100,35,217,240,109,38,139,24,187,157,215,110,199,57,147,184,37,1,102,17,83,106,8,215,60,121,158,75,220,113,124,169,98,94,144,21,145,40,52,54,29,223,247,97,172,178,56,102,50,159,86,114,193,4,177,129,136,184,144,150,100,80,37,27,100,69,247,106,182,111,209,87,223,152,102,20,148,150,148,215,47,82,164,217,58,226,1,4,133,201,211,177,192,16,142,82,121,23,170,99,82,59,228,54,151,34,69,169,169,108,67,152,23,30,138,100,74,247,55,24,175,81,186,183,84,46,152,64,47,122,115,122,149,108,68,175,111,194,170,227,186,62,254,124,39,191,194,22,245,136,114,167,103,95,250,56,195,36,44,195,32,169,212,217,170,175,116,224,255,42,223,94,240,202,164,93,243,213,185,74,111,81,211,232,164,84,204,53,143,184,206,23,248,59,227,18,99,76,180,114,109,193,76,48,149,233,19,138,65,121,149,34,236,127,161,177,212,208,11,166,176,146,6,112,181,64,22,222,37,81,110,47,69,179,173,55,168,159,68,104,122,42,205,218,149,117,114,210,82,176,157,192,76,34,169,44,141,219,135,194,148,35,81,103,178,170,125,185,92,185,247,3,245,216,194,78,221,254,200,96,91,26,218,30,141,53,97,205,174,21,10,178,175,224,5,215,144,178,45,30,247,142,211,20,121,7,162,223,100,142,83,38,89,12,102,181,39,189,76,70,189,233,131,140,188,177,95,168,223,80,101,82,106,250,120,218,199,216,175,65,197,34,220,209,126,20,155,100,15,134,179,42,49,67,202,77,41,178,51,55,110,80,91,219,66,219,157,69,186,90,146,21,249,187,74,118,226,25,221,178,24,6,49,191,91,222,247,6,240,32,249,61,198,105,100,58,67,90,42,1,129,231,100,211,42,52,193,46,68,152,47,117,30,25,16,1,42,191,7,173,247,40,89,154,98,56,40,122,103,6,12,149,190,20,50,102,250,136,80,170,188,159,74,36,3,168,175,194,199,184,83,123,222,188,60,173,145,187,74,75,115,140,169,37,245,96,217,227,103,221,20,114,223,50,140,163,38,165,233,181,190,162,68,79,200,200,105,100,109,75,203,188,10,196,57,92,224,230,181,154,216,129,121,237,137,153,140,74,139,123,8,152,14,158,192,253,254,39,192,212,204,10,96,255,157,143,183,207,9,96,69,180,23,173,6,158,218,168,150,19,185,255,7,119,20,159,136,194,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f90e9aa-9e05-4910-b594-3ce033df149a"));
		}

		#endregion

	}

	#endregion

}

