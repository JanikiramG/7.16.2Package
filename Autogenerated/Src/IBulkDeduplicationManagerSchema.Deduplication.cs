﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkDeduplicationManagerSchema

	/// <exclude/>
	public class IBulkDeduplicationManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkDeduplicationManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkDeduplicationManagerSchema(IBulkDeduplicationManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fb400a12-d325-494b-95d3-08ad728af5c2");
			Name = "IBulkDeduplicationManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,86,203,106,219,64,20,93,199,224,127,184,56,155,22,130,180,79,28,67,147,22,99,104,218,144,56,171,210,197,88,115,229,12,145,102,212,121,16,68,200,191,119,30,146,37,203,242,35,13,134,208,149,102,230,190,206,61,247,140,36,78,114,84,5,73,16,230,40,37,81,34,213,209,181,224,41,91,26,73,52,19,60,250,138,212,20,25,75,252,110,56,120,25,14,78,140,98,124,9,247,165,210,152,95,12,7,246,228,84,226,210,154,97,198,53,202,212,166,59,135,217,149,201,158,214,130,111,8,39,75,148,62,32,142,99,24,43,147,231,68,150,147,106,239,2,128,182,35,32,15,33,81,29,17,183,66,10,179,176,126,192,234,146,219,43,66,31,154,57,81,79,247,154,72,237,16,157,188,120,84,171,62,110,80,63,10,170,206,225,214,23,9,198,46,102,127,48,69,173,236,41,34,36,18,211,203,209,70,157,25,79,197,40,158,68,171,12,113,55,197,184,32,146,228,192,237,40,46,71,200,53,211,229,15,187,30,77,190,249,181,55,68,227,216,123,53,65,18,181,145,92,77,14,168,61,142,107,103,23,221,235,229,250,216,56,252,164,180,116,147,110,48,125,190,120,43,21,85,70,84,83,41,76,113,103,197,38,184,194,99,16,210,14,74,68,102,114,174,86,17,213,222,91,213,238,80,145,166,10,245,104,210,32,7,133,25,38,26,130,101,95,97,195,123,131,165,120,6,111,60,124,146,219,169,235,25,104,191,179,31,107,109,242,92,176,202,67,109,14,247,12,194,209,175,223,53,95,103,238,118,85,125,135,181,111,97,191,10,150,190,132,141,4,218,48,241,204,244,99,179,15,133,45,156,232,191,212,76,197,192,187,164,179,158,99,135,130,218,105,180,40,154,20,183,40,61,135,107,105,125,18,59,205,144,127,187,30,167,71,26,226,155,212,27,64,252,76,27,151,119,8,55,44,123,25,218,175,233,22,9,139,178,226,238,131,234,209,131,155,209,214,212,3,94,96,212,65,73,153,253,164,126,208,151,96,131,184,38,185,2,77,29,232,174,202,2,53,215,25,179,30,29,17,245,126,247,118,248,247,190,42,175,74,111,59,76,114,83,195,40,84,212,255,203,155,243,11,165,10,36,38,66,218,167,22,96,56,251,99,170,43,86,66,198,148,62,170,222,66,185,59,95,127,70,173,238,30,66,253,128,8,136,253,61,44,183,207,205,222,89,147,185,142,129,80,218,185,226,11,33,50,215,221,92,132,148,223,109,43,125,148,58,2,45,161,29,32,53,103,167,200,105,248,61,243,251,215,240,227,185,118,248,250,23,103,43,30,217,207,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb400a12-d325-494b-95d3-08ad728af5c2"));
		}

		#endregion

	}

	#endregion

}
