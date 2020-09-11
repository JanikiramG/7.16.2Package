﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationServiceSchema

	/// <exclude/>
	public class TranslationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationServiceSchema(TranslationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc8a0dcf-5d5b-4c7c-9ead-6940b495da41");
			Name = "TranslationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d72ca66-8680-4c3f-b4a0-15ba7a19db7c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,87,91,83,235,54,16,126,206,153,57,255,65,147,190,56,211,212,188,19,2,3,1,58,76,9,135,33,161,231,161,211,97,20,123,19,84,100,217,149,228,64,122,134,255,222,149,111,145,99,217,9,156,23,176,86,187,171,111,47,250,86,17,52,2,149,208,0,200,28,164,164,42,94,106,127,18,139,37,91,165,146,106,22,11,127,46,169,80,60,251,254,250,229,199,215,47,189,84,49,177,34,179,141,210,16,141,118,214,104,203,57,4,70,89,249,191,131,0,201,130,134,206,12,228,154,5,48,141,67,224,254,57,42,175,51,239,13,189,239,176,64,93,165,112,111,166,169,134,173,130,141,85,182,202,235,129,180,106,93,211,64,199,146,129,114,105,24,12,147,56,138,58,236,47,47,112,11,55,127,145,176,194,115,200,132,83,165,142,137,149,183,34,224,76,235,175,115,149,220,129,70,159,9,238,45,24,103,122,243,0,255,166,76,66,4,66,43,207,94,152,20,145,49,217,99,98,180,252,66,16,14,254,198,67,146,116,193,89,64,2,131,196,1,132,28,147,11,170,160,88,13,201,77,83,5,133,15,64,195,111,130,111,236,18,160,239,31,89,24,219,104,177,210,154,34,138,99,114,47,77,37,243,48,123,73,190,32,129,217,39,74,203,44,115,219,115,176,238,41,229,236,63,192,51,176,222,51,208,26,53,38,121,192,253,22,197,254,232,99,174,175,164,140,229,20,241,211,21,220,97,167,27,215,213,174,101,145,233,245,71,69,100,32,194,60,184,122,164,247,50,78,64,106,108,148,150,80,111,92,24,164,202,251,107,67,158,116,215,246,232,3,158,186,119,205,29,237,245,86,160,139,175,30,91,18,175,251,112,50,30,19,145,114,62,40,77,122,251,244,243,46,47,150,120,211,245,73,55,230,83,175,112,220,19,240,154,55,141,76,205,206,185,92,165,166,139,189,126,170,64,226,134,200,233,163,63,36,143,53,193,96,48,202,93,188,231,255,36,232,84,138,67,178,154,91,188,231,197,58,58,58,34,39,42,141,34,138,160,74,129,5,157,208,202,137,95,233,31,217,6,221,69,106,1,116,64,121,221,101,109,150,179,51,112,114,118,86,36,186,165,228,88,186,206,66,153,90,58,21,188,178,0,159,202,102,190,10,49,250,150,172,102,18,36,52,42,95,84,37,248,131,137,16,1,95,162,217,156,69,96,150,254,163,14,182,30,108,131,50,187,165,118,27,219,52,51,138,22,244,79,202,83,152,111,18,48,32,173,213,184,72,103,189,25,253,154,201,148,10,36,24,105,82,87,147,95,108,170,79,79,227,159,120,233,149,224,170,110,174,208,134,229,199,152,108,249,208,12,81,157,57,241,234,0,134,135,113,233,176,64,95,158,226,79,153,200,220,53,142,87,116,13,151,91,8,91,160,181,116,84,112,174,99,57,67,139,6,170,50,138,210,127,209,172,182,247,102,23,149,149,187,101,74,159,228,124,126,90,239,239,36,225,27,148,222,198,171,81,171,193,220,169,127,216,253,177,244,207,206,118,216,210,218,67,150,68,246,178,79,117,222,138,182,9,50,5,253,28,135,109,227,99,29,179,144,124,19,223,37,211,112,27,7,217,173,89,112,200,210,157,13,40,47,94,252,131,121,38,10,221,131,28,18,183,230,26,201,20,73,85,17,40,217,220,157,24,255,60,12,61,243,110,80,41,215,126,49,36,243,96,222,29,192,38,28,168,124,20,72,210,225,3,44,65,130,8,192,43,79,88,83,137,115,24,31,67,33,14,201,0,194,84,66,145,171,89,93,218,232,151,190,86,201,211,3,68,241,26,118,156,171,254,128,80,181,235,32,79,246,206,89,254,61,13,94,172,17,143,62,95,86,79,86,216,125,183,217,213,27,4,169,198,48,92,81,223,92,9,28,76,210,36,246,196,114,133,15,220,52,18,229,203,18,78,9,222,8,188,115,13,13,85,169,132,181,52,233,86,69,138,232,156,131,181,211,189,177,42,135,235,207,142,214,226,102,116,67,220,25,16,142,104,71,31,186,10,217,83,181,99,154,84,228,166,108,96,109,179,57,127,248,102,29,235,122,232,85,165,208,213,67,169,231,156,118,190,211,186,133,115,75,178,179,121,27,63,46,97,249,51,212,93,13,50,51,242,238,226,215,146,104,72,64,117,240,76,188,171,183,0,146,108,172,194,91,245,112,155,170,213,228,153,226,81,252,81,155,31,10,248,90,245,239,99,165,139,251,125,24,148,221,103,243,16,79,168,51,4,38,240,89,198,175,7,62,8,12,235,176,143,212,175,249,123,4,105,42,193,206,134,204,215,102,79,69,221,92,53,234,42,119,59,235,146,95,199,157,172,220,233,182,250,220,53,85,94,71,57,7,59,163,170,61,29,254,68,2,118,201,53,101,28,239,94,206,229,30,84,174,151,76,80,206,247,116,122,71,232,191,29,18,250,187,205,29,123,161,206,210,0,185,93,21,80,221,163,169,198,32,206,142,154,60,67,240,162,8,254,178,177,122,74,97,42,5,89,0,161,89,191,133,159,238,177,204,187,171,199,62,23,100,23,33,230,210,186,16,101,255,3,35,216,241,253,151,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc8a0dcf-5d5b-4c7c-9ead-6940b495da41"));
		}

		#endregion

	}

	#endregion

}

