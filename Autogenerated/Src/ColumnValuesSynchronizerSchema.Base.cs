﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValuesSynchronizerSchema

	/// <exclude/>
	public class ColumnValuesSynchronizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValuesSynchronizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValuesSynchronizerSchema(ColumnValuesSynchronizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b503b299-5926-4c43-97e3-aaaeb4759ec5");
			Name = "ColumnValuesSynchronizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,86,77,79,220,48,16,61,7,137,255,48,128,132,178,18,74,238,176,187,28,182,180,226,64,85,105,171,222,189,217,89,214,109,98,167,182,3,218,2,255,189,142,157,236,218,78,246,3,170,30,224,18,201,206,204,155,143,188,55,25,70,10,148,37,201,16,190,163,16,68,242,133,74,38,156,45,232,125,37,136,162,156,37,55,76,81,181,154,174,88,182,20,156,209,63,230,246,248,232,233,248,232,248,40,170,36,101,247,48,93,73,133,133,246,203,115,204,234,215,50,249,130,12,5,205,174,214,54,46,188,64,139,74,81,94,25,152,51,129,247,218,13,38,57,145,242,18,52,80,85,176,31,36,175,80,110,2,163,48,182,105,154,194,80,86,69,65,196,106,220,156,29,35,9,104,18,134,204,128,192,131,65,73,90,199,212,241,44,171,89,78,51,200,234,160,91,99,194,37,220,110,207,39,178,109,88,23,112,135,106,201,231,186,132,111,130,62,16,133,246,109,152,178,185,48,29,34,57,224,239,74,63,51,94,148,68,119,156,139,100,237,145,134,46,195,218,164,0,166,191,217,232,84,242,74,100,104,146,58,29,79,205,193,22,155,12,83,99,215,239,54,71,169,40,51,31,177,241,253,180,185,217,6,32,80,85,130,201,241,237,162,1,19,184,232,73,35,29,3,149,77,65,138,119,76,187,161,117,164,22,186,142,85,218,166,193,140,243,28,110,106,152,201,186,45,49,159,253,212,228,2,39,222,5,52,119,33,240,0,158,106,184,200,98,67,236,248,192,201,8,88,149,231,112,126,238,66,37,38,154,140,59,72,3,3,20,69,207,207,62,204,104,3,19,250,180,239,6,53,249,163,151,29,20,248,76,243,92,118,218,100,137,123,71,202,82,235,230,116,236,226,195,35,85,203,189,14,54,79,79,0,175,35,213,154,79,86,74,7,19,202,231,210,33,206,65,234,86,104,80,216,179,231,218,114,227,129,211,185,105,156,181,141,237,120,106,106,190,128,230,232,36,117,97,191,96,48,192,38,110,96,240,210,104,217,227,96,36,83,84,206,16,136,61,251,196,41,218,26,125,213,181,53,97,109,94,122,28,238,240,183,205,222,184,14,246,51,231,142,168,108,137,251,185,211,67,5,32,108,190,207,175,13,51,239,140,6,208,35,64,45,113,5,68,96,163,116,249,139,150,178,190,44,146,55,48,154,107,71,241,72,229,71,163,168,243,159,176,46,242,63,82,181,59,27,97,4,111,162,222,149,139,215,157,108,238,213,110,228,94,81,52,240,189,5,110,70,189,229,149,115,30,249,85,39,206,171,235,235,240,71,97,67,208,5,196,39,1,78,236,253,59,186,163,190,105,230,191,10,223,253,12,77,193,47,142,158,207,144,205,237,182,176,109,117,48,107,201,14,241,123,219,142,229,42,134,63,100,173,178,62,157,123,74,120,23,138,147,161,228,164,175,57,187,195,133,146,107,215,203,131,53,119,187,89,94,135,187,244,55,246,169,40,91,210,44,244,82,75,178,37,196,135,139,23,40,219,2,22,245,12,143,182,2,55,245,96,24,116,185,182,119,235,192,45,212,232,95,52,214,212,234,236,214,31,137,70,117,127,156,88,150,50,239,148,72,206,162,244,38,2,5,195,202,222,250,151,250,238,47,162,27,150,179,69,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b503b299-5926-4c43-97e3-aaaeb4759ec5"));
		}

		#endregion

	}

	#endregion

}

