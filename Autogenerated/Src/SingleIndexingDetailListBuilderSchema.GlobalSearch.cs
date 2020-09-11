﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SingleIndexingDetailListBuilderSchema

	/// <exclude/>
	public class SingleIndexingDetailListBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SingleIndexingDetailListBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SingleIndexingDetailListBuilderSchema(SingleIndexingDetailListBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45a6e1ee-50ac-44bb-8843-0ac459b3e1d8");
			Name = "SingleIndexingDetailListBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("22387ba7-4aa5-4ad3-8c5e-98af882ce17b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,109,79,219,48,16,254,12,18,255,193,234,38,145,74,89,58,190,82,138,4,29,84,104,99,234,40,27,31,145,137,175,173,37,215,9,182,195,136,74,254,251,206,118,66,243,82,64,99,147,170,52,62,223,221,243,220,107,36,93,129,78,105,12,228,26,148,162,58,153,155,104,156,200,57,95,100,138,26,158,200,104,34,146,59,42,102,64,85,188,220,219,93,239,237,238,100,154,203,5,153,229,218,192,106,216,58,163,177,16,16,91,75,29,77,64,130,226,241,70,167,142,161,224,37,121,116,38,13,55,28,180,85,192,223,7,5,11,244,71,198,130,106,125,72,102,104,33,224,66,50,120,196,183,47,96,40,23,223,184,54,167,25,23,12,148,183,73,179,59,193,99,18,91,147,183,44,200,33,121,205,155,13,217,186,220,240,192,216,140,202,98,147,40,164,51,117,72,149,206,96,48,32,71,92,46,49,110,195,146,120,112,108,133,37,153,55,104,4,63,53,40,244,45,125,250,72,214,56,246,145,229,29,213,16,180,197,235,226,153,31,72,230,41,182,25,95,130,89,38,204,146,85,137,65,67,96,175,243,173,180,72,242,128,149,225,12,158,19,228,74,147,147,9,152,166,36,248,10,249,47,42,50,152,82,174,142,48,61,120,19,18,127,55,139,151,176,162,63,50,80,249,49,1,39,114,7,228,110,209,118,30,168,34,188,233,127,228,98,141,186,48,117,243,161,179,110,90,70,23,218,167,25,93,96,141,192,235,40,48,153,146,45,16,119,85,252,109,34,30,18,206,200,73,154,138,124,170,248,138,170,28,27,62,91,201,171,76,64,208,9,215,223,145,212,107,158,233,123,47,8,29,169,142,54,1,125,31,18,159,187,142,205,137,224,84,215,51,54,231,194,96,239,142,172,85,52,86,64,13,156,59,209,13,55,203,41,85,56,216,120,208,129,23,142,147,85,74,21,215,137,188,206,83,156,176,251,140,138,112,59,72,72,28,198,206,36,227,44,58,91,165,38,15,201,230,189,204,186,5,245,158,117,116,194,88,224,217,244,223,151,211,50,100,172,246,236,94,92,195,163,233,102,210,70,89,69,95,170,107,175,91,235,149,202,218,234,14,235,170,92,158,87,217,250,216,219,95,175,215,155,120,138,162,216,15,73,87,214,107,116,78,137,21,93,65,42,112,89,6,149,195,144,220,114,102,103,248,146,198,42,121,103,248,221,96,167,10,176,90,224,87,4,86,103,251,116,249,255,99,194,156,218,115,231,248,227,44,155,207,249,35,6,220,235,181,242,102,61,75,227,225,190,99,151,160,142,55,137,28,196,176,211,156,229,117,67,52,34,183,205,69,20,213,175,47,169,164,11,80,216,33,146,93,224,178,164,50,134,211,220,130,5,37,20,6,212,223,130,84,231,246,126,140,118,132,213,166,152,147,96,91,40,35,34,51,33,200,211,83,11,222,203,171,236,85,173,96,101,222,95,241,242,24,35,119,236,199,47,48,183,197,235,98,182,186,147,149,123,162,52,178,218,83,199,196,203,107,121,11,73,111,253,185,136,214,7,69,175,244,97,87,65,90,83,118,35,124,163,104,234,189,181,132,41,126,102,234,65,70,141,37,22,213,146,101,7,28,7,219,95,4,21,197,126,52,3,115,158,168,24,88,109,193,185,190,113,24,193,86,42,53,170,255,99,107,85,100,66,242,175,155,170,170,41,234,188,111,116,185,52,155,66,95,37,191,199,73,38,77,80,181,76,233,253,211,65,211,121,253,59,141,231,194,61,27,31,239,189,221,226,15,83,29,202,194,153,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45a6e1ee-50ac-44bb-8843-0ac459b3e1d8"));
		}

		#endregion

	}

	#endregion

}

