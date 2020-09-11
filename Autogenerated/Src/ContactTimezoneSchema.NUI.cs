﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactTimezoneSchema

	/// <exclude/>
	public class ContactTimezoneSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactTimezoneSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactTimezoneSchema(ContactTimezoneSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("096b0a2c-adfd-4827-b564-e8d86a8648f8");
			Name = "ContactTimezone";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,26,219,110,219,54,244,89,5,246,15,172,11,20,50,16,40,221,107,19,7,72,156,164,243,208,52,89,146,174,192,134,33,80,36,58,17,166,139,75,82,109,221,34,255,62,146,135,20,47,162,100,187,43,176,245,33,182,201,115,191,147,108,157,86,152,174,210,12,163,91,76,72,74,155,37,75,230,77,189,44,30,90,146,178,162,169,127,122,246,237,167,103,81,75,139,250,1,221,172,41,195,213,129,247,59,57,77,89,218,91,156,55,101,137,51,65,129,38,111,112,141,73,145,25,24,155,87,85,53,117,120,135,224,161,245,228,172,102,5,43,48,29,4,56,61,225,91,124,243,5,193,15,92,6,52,47,83,74,95,35,174,26,75,51,118,91,84,248,107,83,99,9,178,106,239,203,34,67,153,128,240,1,208,107,180,232,225,68,223,36,158,79,251,138,20,159,82,6,52,163,21,252,80,84,223,54,153,52,166,166,193,141,211,86,53,125,199,141,47,128,133,133,35,45,7,101,68,232,51,111,114,140,190,161,7,204,14,16,21,127,158,128,176,7,166,41,47,242,29,128,125,208,40,82,240,47,112,157,131,82,174,134,231,5,46,243,33,21,239,155,166,68,119,5,229,142,63,206,171,162,126,95,23,76,217,12,205,208,50,45,169,244,99,7,79,112,154,55,117,185,70,139,179,186,173,48,73,239,75,124,56,98,161,35,116,183,34,205,178,40,113,96,19,205,164,158,81,141,63,163,183,5,101,163,132,226,41,2,83,75,232,97,64,1,7,14,152,161,137,248,156,40,43,253,91,61,210,156,155,151,210,255,70,143,130,173,5,204,31,18,134,235,180,103,7,15,7,232,8,112,192,69,110,109,107,236,201,211,222,206,92,175,101,0,109,197,23,64,123,156,97,249,123,120,207,155,182,102,100,75,165,1,182,175,55,172,79,58,255,143,165,9,143,122,158,105,109,198,26,34,146,69,230,30,64,236,239,239,163,67,218,86,85,74,214,71,122,97,193,19,165,72,203,226,43,70,66,173,130,35,167,53,175,196,205,18,177,71,85,58,146,14,123,223,71,63,92,165,36,173,80,205,213,158,77,90,138,9,103,95,67,201,157,28,189,231,191,81,214,45,116,196,15,247,37,150,36,162,138,131,87,223,226,247,14,41,228,82,214,145,231,1,205,60,176,131,45,138,202,21,105,86,152,136,42,46,10,75,195,56,38,206,221,210,226,113,185,11,48,89,105,76,31,216,251,9,98,243,138,167,190,69,197,18,197,159,210,178,229,161,50,67,117,91,150,90,181,40,98,143,164,249,44,125,114,76,30,120,106,215,236,29,223,63,251,146,225,149,160,21,251,214,158,30,0,226,19,124,120,98,114,227,72,62,0,4,48,15,70,14,130,89,75,194,186,69,118,109,214,54,121,211,22,57,186,203,192,105,139,220,51,130,220,157,235,205,17,173,147,179,143,45,47,205,177,64,72,206,170,21,91,79,199,12,32,33,44,11,116,252,123,202,119,59,91,234,237,106,18,109,211,142,46,48,123,108,6,251,145,23,207,139,122,217,160,55,88,183,164,227,44,19,41,125,236,86,226,174,162,222,96,49,181,240,206,40,63,102,27,17,1,62,86,70,80,58,93,243,206,160,1,206,73,83,1,208,53,166,109,201,98,32,189,55,214,12,166,7,1,191,43,201,182,21,104,88,31,57,141,165,165,194,83,240,19,151,26,175,130,154,238,122,133,101,93,163,201,91,252,144,150,139,92,233,10,36,147,95,155,162,142,197,31,1,200,65,150,236,178,101,152,236,137,210,41,197,156,76,193,223,201,37,15,27,189,198,183,21,67,17,65,201,130,202,104,12,72,97,131,73,58,201,135,71,76,176,67,201,33,1,102,76,174,68,149,195,92,144,184,75,134,169,235,36,144,63,100,233,13,1,180,123,228,252,127,66,230,199,196,138,75,45,24,43,191,52,21,246,67,197,245,156,229,227,185,41,38,63,210,143,70,253,160,26,106,40,206,92,211,112,21,246,160,138,86,105,81,91,171,156,177,103,167,246,30,120,159,55,100,158,82,12,22,187,241,86,227,62,153,131,65,42,124,200,146,3,71,128,148,222,242,226,70,212,104,165,143,219,240,166,201,109,179,138,127,214,201,7,230,140,67,202,78,28,233,38,219,96,168,17,209,3,133,33,81,39,228,49,141,253,145,210,135,87,163,93,8,163,27,6,123,60,212,64,22,100,211,13,113,62,22,251,170,101,147,83,32,160,245,38,226,62,150,145,208,194,11,204,180,1,126,70,78,155,101,96,36,245,112,85,224,115,231,235,56,245,34,106,10,164,46,252,184,218,141,144,142,39,69,109,193,179,130,73,27,169,50,43,138,80,192,249,106,119,164,234,27,26,170,228,219,65,161,179,123,115,84,141,176,80,78,177,153,120,145,52,202,198,11,173,209,14,6,62,116,59,152,27,127,227,26,121,1,57,194,75,135,132,10,20,21,176,33,67,106,72,183,115,154,8,255,46,110,163,54,29,226,232,90,125,119,13,199,205,59,168,167,235,129,77,108,45,143,56,156,236,245,173,156,25,74,182,228,146,228,152,156,172,79,49,205,134,83,210,133,234,165,154,189,27,14,35,130,121,63,203,47,185,127,80,74,85,189,31,239,120,3,189,67,117,176,141,205,195,173,36,231,109,157,37,64,65,218,73,111,203,26,161,50,94,250,52,211,156,58,75,171,158,111,54,184,58,98,94,177,93,170,3,23,214,67,26,110,161,163,104,181,227,109,123,71,165,39,188,92,6,98,196,170,142,110,104,73,3,120,56,238,200,26,38,56,60,241,244,53,209,34,30,215,249,120,0,15,240,26,143,158,129,185,247,202,189,124,27,27,23,61,80,119,210,13,145,47,196,159,217,150,211,239,240,45,160,158,51,97,162,99,250,242,118,38,233,39,6,33,87,135,209,193,219,202,231,64,130,219,81,156,248,47,137,60,246,198,154,160,59,122,9,218,59,152,145,51,228,121,207,56,245,158,37,101,220,106,38,242,224,44,239,176,157,123,248,196,224,139,11,117,246,187,56,90,31,10,204,35,47,142,185,175,79,241,50,229,166,235,42,46,76,180,234,152,15,74,136,139,128,231,134,167,136,28,169,171,185,5,8,248,215,115,172,65,215,151,0,59,157,102,54,250,243,201,207,219,128,105,227,13,39,31,79,100,207,212,90,217,79,41,233,20,85,119,32,155,234,132,59,148,154,57,78,23,7,211,238,244,186,42,3,150,87,54,20,0,75,78,63,117,119,57,253,12,100,229,160,234,27,53,239,244,182,147,200,111,217,62,172,173,182,51,247,130,185,28,82,122,107,155,97,66,243,185,220,32,143,169,141,131,146,40,7,249,84,118,61,158,238,236,170,80,197,24,77,33,39,53,225,98,60,218,250,21,130,89,229,208,206,57,43,30,172,10,170,10,162,44,14,7,29,64,105,174,200,199,1,100,53,51,197,167,15,32,60,27,164,2,207,122,241,233,201,217,23,156,181,172,33,40,191,239,190,206,188,235,221,228,172,166,45,193,167,39,102,201,170,100,138,212,66,60,84,10,187,98,34,31,111,176,160,163,238,38,128,50,134,221,216,112,178,46,69,69,197,4,180,68,128,89,244,163,104,201,235,117,154,61,162,120,196,242,40,147,223,121,223,216,228,2,241,207,114,129,98,42,175,113,4,44,148,126,176,216,81,12,84,19,65,74,87,97,93,222,199,155,25,122,249,114,160,223,41,146,90,23,1,217,17,142,162,173,112,100,30,24,109,34,39,30,194,10,65,47,235,211,57,232,83,81,65,227,193,90,128,247,156,197,223,230,247,147,254,166,191,60,217,119,214,79,166,33,6,85,179,185,130,213,140,54,250,26,61,135,142,43,251,203,212,168,110,229,9,215,86,11,42,95,170,12,141,61,39,25,118,234,125,154,143,61,226,112,94,218,199,170,52,88,15,90,154,19,240,8,21,35,53,68,249,226,202,198,105,203,172,224,92,227,152,18,66,100,165,26,172,15,152,126,228,123,66,47,249,148,191,190,201,30,113,149,254,214,98,178,142,123,169,109,0,46,210,58,125,16,13,32,96,177,238,62,79,4,5,188,169,10,54,9,159,131,117,15,82,39,15,241,1,56,139,30,247,243,162,228,229,124,193,112,133,150,242,171,162,2,103,48,216,253,80,176,199,174,242,211,24,22,231,77,181,74,73,65,65,38,136,139,61,4,14,16,4,174,155,134,1,159,68,246,228,66,60,230,205,59,97,227,233,158,101,94,165,146,192,3,234,84,168,17,131,68,106,19,68,55,255,207,2,97,245,159,34,148,196,156,139,15,226,247,115,51,10,106,92,56,230,161,35,244,106,106,30,106,148,39,53,204,159,175,254,18,196,133,154,249,112,69,26,154,227,128,220,54,15,132,230,153,103,211,75,234,181,36,77,245,93,46,122,115,113,219,229,192,182,47,168,230,69,235,72,159,7,120,215,178,223,75,37,10,104,65,59,24,135,213,225,190,222,150,25,21,124,95,213,231,129,238,20,32,51,171,227,174,205,110,222,240,102,102,115,227,65,42,116,92,51,78,14,86,183,222,17,73,150,184,240,9,169,139,9,195,46,116,172,177,189,190,3,223,0,245,161,55,151,31,207,97,224,89,48,16,192,254,185,207,11,95,88,117,23,249,218,63,69,33,174,60,105,37,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("096b0a2c-adfd-4827-b564-e8d86a8648f8"));
		}

		#endregion

	}

	#endregion

}

