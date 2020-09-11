﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeListenerServiceSchema

	/// <exclude/>
	public class ExchangeListenerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeListenerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeListenerServiceSchema(ExchangeListenerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("da324162-86d1-4866-8efd-f30356b3f342");
			Name = "ExchangeListenerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("694e66cc-2320-4882-a72b-77a02cf5e28a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,87,89,111,234,70,20,126,230,74,247,63,140,220,60,24,149,154,110,79,185,64,69,182,138,171,108,10,105,243,16,69,213,96,31,200,180,246,140,239,204,192,13,66,252,247,158,89,108,108,48,89,212,180,15,125,137,240,217,207,119,182,9,167,25,168,156,198,64,110,65,74,170,196,84,71,199,130,79,217,108,46,169,102,130,127,252,176,250,248,161,53,87,140,207,200,120,169,52,100,200,79,83,136,13,83,69,191,2,7,201,226,79,219,50,231,140,127,217,33,142,65,46,88,12,23,34,129,244,89,102,52,68,243,11,235,255,121,185,59,152,108,4,78,51,202,82,12,94,75,26,155,44,178,140,242,68,237,227,159,220,94,109,88,179,84,76,104,122,120,104,148,4,143,206,197,108,134,228,13,127,196,53,204,28,32,195,156,69,230,83,78,17,181,138,245,42,126,198,72,51,71,66,116,134,222,133,100,205,186,54,198,19,129,127,249,11,94,48,245,141,39,228,127,35,97,134,225,145,227,148,42,117,72,78,159,226,71,202,103,112,206,16,53,172,145,135,205,138,118,187,93,210,83,115,196,71,46,7,254,219,170,145,92,138,5,75,64,145,175,48,33,202,169,16,224,73,46,24,215,100,42,36,1,111,151,164,222,112,41,38,225,203,28,148,182,70,48,102,19,110,84,56,235,86,188,221,251,80,138,74,60,24,218,80,229,151,160,49,159,28,65,158,176,148,233,229,13,218,99,18,50,224,90,133,213,15,83,122,210,39,47,168,24,169,200,19,146,182,113,146,207,39,41,139,73,108,51,221,131,15,57,36,71,84,65,137,86,107,101,17,43,209,61,99,144,38,8,239,181,52,253,233,224,220,193,211,19,0,72,44,97,218,15,70,216,79,65,119,64,24,87,154,242,24,162,82,166,138,75,43,119,54,9,10,105,140,83,2,77,4,79,151,196,168,147,63,82,252,211,39,248,243,130,114,58,3,137,163,167,77,159,130,12,131,237,100,130,246,39,31,54,214,206,69,94,79,227,2,244,163,168,229,209,106,237,205,228,24,35,209,216,19,9,83,121,74,151,24,159,52,173,104,186,161,151,83,73,51,76,146,112,92,36,253,0,22,6,122,204,117,79,138,150,98,117,234,10,131,34,3,226,8,4,155,144,107,54,101,49,197,89,81,36,46,87,78,212,235,90,253,141,57,9,122,46,185,26,156,188,37,188,94,183,80,171,35,111,85,17,217,27,4,159,78,82,56,181,26,6,215,208,49,239,31,124,136,109,98,22,99,171,229,236,144,131,224,126,229,36,162,207,56,44,97,208,9,58,133,228,250,33,48,19,220,90,187,34,188,11,208,102,79,188,9,104,167,48,176,11,70,17,220,126,239,6,106,25,202,171,65,181,26,22,212,209,41,159,103,32,13,181,103,201,3,226,236,189,10,94,43,137,23,193,164,17,226,78,24,24,47,110,133,186,184,127,167,233,28,66,104,183,183,107,240,46,248,191,21,126,143,190,1,255,159,35,254,26,192,119,161,112,1,88,3,91,8,91,26,233,247,9,159,167,169,101,180,126,241,166,240,42,229,122,233,104,135,88,138,149,149,141,198,243,201,159,8,252,186,67,198,184,102,78,140,107,205,240,57,161,105,150,147,66,198,115,110,145,49,54,12,148,62,147,34,171,242,65,34,145,37,5,105,148,172,107,165,122,121,135,217,189,238,152,247,87,57,184,59,93,61,47,173,123,188,150,35,190,16,127,65,232,212,112,149,6,215,87,227,91,236,162,35,145,44,199,122,153,154,155,130,98,23,120,186,112,191,150,212,232,78,210,60,135,164,99,243,191,113,71,238,76,200,140,234,154,130,35,69,159,149,224,29,114,131,143,42,124,30,193,243,114,246,42,21,103,105,33,16,130,75,248,106,43,20,22,251,208,126,217,37,68,56,242,204,143,162,110,230,34,224,27,97,42,156,197,48,40,148,9,195,119,210,40,33,41,240,153,126,68,231,171,239,17,224,77,105,144,240,131,67,28,127,253,136,191,230,120,194,109,103,145,213,79,107,191,181,70,137,50,236,159,215,129,75,188,85,184,143,126,227,12,49,64,126,116,110,29,116,202,200,34,251,183,44,117,133,49,74,42,31,248,144,27,38,25,227,104,72,95,162,91,239,160,121,235,238,186,109,183,109,119,180,22,84,22,79,13,156,145,190,123,193,184,199,213,210,28,199,222,168,4,209,154,187,46,100,7,161,183,80,106,71,158,87,194,95,98,93,109,196,127,161,183,142,168,132,255,164,177,124,130,103,56,219,46,195,115,65,19,255,32,182,239,100,191,76,113,86,105,209,96,108,74,194,13,213,61,77,85,52,82,151,104,228,74,218,157,16,182,11,97,215,142,119,84,242,240,32,216,246,102,183,88,223,15,184,179,134,203,67,197,146,229,6,78,211,196,102,236,113,221,8,51,106,228,59,194,133,15,136,228,88,85,72,2,95,50,191,173,220,199,186,62,7,77,142,93,147,191,224,183,19,144,111,157,245,131,160,58,12,207,169,85,155,120,93,156,34,227,171,249,206,237,224,216,94,7,149,62,134,114,204,55,109,218,220,210,13,130,101,63,55,89,41,90,123,187,222,149,136,254,111,77,126,129,137,77,196,19,238,32,141,209,86,62,72,86,249,40,26,215,192,143,29,228,237,163,51,127,243,48,125,124,124,110,122,170,201,144,169,119,213,166,63,103,22,231,97,130,87,75,41,236,141,98,131,30,4,116,65,83,102,58,99,71,113,88,112,106,242,248,207,22,216,150,219,145,63,45,56,182,69,204,22,173,41,102,101,54,123,212,124,186,53,165,24,11,14,79,122,71,233,216,209,203,134,53,123,161,57,248,250,50,176,51,185,129,214,107,175,9,164,10,106,130,167,82,10,217,32,185,153,15,12,141,187,167,234,107,134,164,90,170,125,179,178,215,98,212,212,69,181,198,121,230,113,226,168,85,34,190,246,145,248,55,123,61,54,120,103,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("da324162-86d1-4866-8efd-f30356b3f342"));
		}

		#endregion

	}

	#endregion

}

