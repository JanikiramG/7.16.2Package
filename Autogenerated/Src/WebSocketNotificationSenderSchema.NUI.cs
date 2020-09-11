﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebSocketNotificationSenderSchema

	/// <exclude/>
	public class WebSocketNotificationSenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebSocketNotificationSenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebSocketNotificationSenderSchema(WebSocketNotificationSenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dbf82f63-6b83-4a3a-bf0c-9e269fb22dab");
			Name = "WebSocketNotificationSender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,217,110,219,56,20,125,86,129,254,3,225,98,0,25,72,245,1,233,100,128,196,113,82,97,146,52,19,57,232,99,192,136,215,50,17,153,244,144,84,90,97,224,127,159,75,138,138,169,205,69,139,190,24,230,221,151,195,67,9,186,5,189,163,57,144,21,40,69,181,92,155,100,33,197,154,23,149,162,134,75,241,254,221,127,239,223,69,149,230,162,32,89,173,13,108,63,245,206,104,95,150,144,91,99,157,92,131,0,197,243,129,205,13,23,255,30,132,97,46,5,227,242,237,86,138,49,205,45,104,77,11,148,29,108,208,234,131,130,2,11,32,139,146,106,125,74,190,194,115,38,243,23,48,119,210,240,53,207,93,43,25,8,6,202,153,239,170,231,146,231,36,183,214,199,140,201,41,73,67,233,103,42,88,105,99,68,118,42,135,172,216,186,161,194,96,230,123,197,95,169,1,151,37,218,53,7,146,91,61,209,70,185,137,44,239,46,151,15,228,140,204,194,200,169,88,203,89,211,75,244,1,115,55,145,253,217,167,185,226,80,178,169,28,10,40,147,162,172,201,173,46,22,27,42,4,148,183,84,208,2,155,120,202,59,231,79,163,110,190,186,167,103,201,234,85,189,131,59,68,70,199,242,81,131,194,70,69,179,106,242,84,117,206,63,40,221,77,72,85,218,72,101,27,112,227,247,245,55,171,56,178,132,184,151,185,155,120,126,74,204,134,235,184,43,61,241,253,36,203,237,206,212,115,226,214,181,255,61,25,219,216,36,28,149,79,17,245,198,130,107,30,204,201,90,117,55,130,86,131,173,37,169,195,84,14,222,35,76,134,246,131,53,237,143,47,224,22,204,70,78,130,39,61,164,39,215,96,240,210,158,179,45,23,143,130,27,47,142,175,43,206,136,14,20,109,199,10,76,165,68,31,100,201,21,23,44,197,171,127,81,63,166,44,238,56,134,245,182,21,92,226,207,138,99,107,15,178,18,204,157,100,6,120,113,152,142,223,116,12,255,100,178,82,57,244,146,31,20,201,57,99,43,158,191,232,216,122,100,59,42,18,119,188,7,213,132,35,31,73,28,152,59,37,249,131,76,88,207,143,23,139,179,186,161,218,60,0,182,198,172,36,238,21,54,210,77,15,33,201,162,82,10,132,177,144,67,250,52,254,216,166,136,199,43,232,83,199,3,178,56,94,49,87,209,148,46,78,151,162,218,130,162,207,37,252,153,246,173,254,34,34,144,232,182,143,87,170,144,190,42,97,64,105,132,93,199,38,249,186,1,5,49,130,28,157,147,107,37,171,157,133,99,146,106,12,238,46,30,86,239,162,68,141,246,162,30,24,183,250,12,236,27,18,23,86,238,76,224,155,175,32,138,156,48,249,27,234,19,47,88,216,130,176,154,70,225,78,177,15,180,159,39,43,121,201,221,104,169,170,227,239,54,216,119,231,76,252,127,103,63,247,132,229,26,20,83,211,60,115,117,76,14,219,23,184,56,204,167,29,149,175,52,244,28,140,207,153,236,155,235,205,215,100,0,12,92,101,170,175,128,34,144,96,41,236,214,88,60,67,152,88,104,92,73,213,137,253,79,5,170,158,205,219,173,69,83,29,37,93,184,98,73,35,16,110,74,218,135,56,158,138,55,134,77,75,38,54,108,203,103,238,193,134,33,129,156,76,15,118,219,248,92,32,201,133,64,244,98,191,150,140,111,119,37,248,240,109,227,41,67,109,39,75,35,183,161,80,19,4,246,138,207,248,0,58,6,110,209,230,95,254,51,255,80,183,152,187,232,242,111,135,143,61,244,194,133,250,185,249,124,99,99,122,149,56,15,155,108,114,64,41,251,185,17,133,44,238,217,184,89,240,24,159,119,19,205,15,48,124,243,196,41,87,101,249,6,169,166,163,16,27,110,209,135,157,12,87,222,111,38,172,185,9,228,147,37,247,82,155,214,203,91,205,127,238,89,27,126,82,184,1,55,95,108,191,68,125,93,174,91,108,32,127,57,87,5,134,17,230,14,7,243,69,53,20,55,235,216,205,124,99,125,90,113,132,55,100,208,150,22,11,75,77,69,146,13,158,201,104,141,95,200,52,223,144,120,52,34,225,98,36,205,219,206,130,75,227,47,192,177,247,97,16,8,169,244,134,107,211,190,65,205,221,104,215,52,180,118,36,59,220,241,126,98,143,94,214,93,237,254,127,43,233,23,30,146,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dbf82f63-6b83-4a3a-bf0c-9e269fb22dab"));
		}

		#endregion

	}

	#endregion

}
