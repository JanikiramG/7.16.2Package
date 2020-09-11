﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AutoEmailUserTaskSenderSchema

	/// <exclude/>
	public class AutoEmailUserTaskSenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AutoEmailUserTaskSenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AutoEmailUserTaskSenderSchema(AutoEmailUserTaskSenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8b81a07e-f5a5-43a1-b7b8-6c4fdaced4b6");
			Name = "AutoEmailUserTaskSender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,75,111,227,54,16,62,123,129,253,15,172,122,145,1,67,6,122,140,31,64,154,56,93,3,77,106,172,211,237,161,40,10,90,30,203,108,41,81,32,41,39,198,194,255,189,195,135,100,74,86,146,205,94,122,177,69,106,230,155,111,158,164,10,154,131,42,105,10,228,17,164,164,74,236,116,114,35,36,36,43,41,82,80,10,23,197,142,101,149,164,154,137,226,227,135,175,31,63,12,42,197,138,140,172,143,74,67,62,233,172,81,158,115,72,141,176,74,126,129,2,36,75,207,50,161,141,60,23,69,255,155,192,96,191,128,132,151,246,147,59,154,106,33,25,168,23,37,188,99,125,239,239,41,227,201,26,138,45,200,243,235,140,139,13,229,87,87,142,113,242,171,200,50,220,126,147,121,109,231,22,20,203,138,16,16,3,181,6,173,241,81,145,25,177,156,218,154,129,0,106,161,222,143,18,50,124,65,110,56,85,234,138,92,87,90,44,114,228,250,187,2,249,72,213,191,142,178,21,45,171,13,103,41,73,141,228,75,130,228,138,44,123,245,7,95,45,70,99,239,142,1,223,162,193,149,100,7,170,193,189,44,221,130,40,141,108,83,34,129,110,69,193,143,100,137,145,33,127,115,252,153,17,124,188,167,5,205,64,98,13,104,19,50,144,113,228,35,18,13,39,222,12,154,117,150,218,102,81,174,4,169,49,137,104,218,250,227,45,59,223,12,107,12,88,225,170,172,187,52,5,58,24,100,160,39,246,65,249,135,211,235,38,239,65,239,197,182,223,222,129,73,93,81,78,14,130,109,137,9,149,141,221,31,76,239,111,97,71,43,174,93,248,98,187,125,143,14,162,223,4,130,197,136,108,132,224,4,203,0,115,189,144,82,72,53,244,60,15,84,146,170,229,192,181,52,1,44,224,9,43,163,80,90,86,166,158,113,179,202,161,208,113,212,22,142,70,29,247,135,147,6,214,50,184,225,12,213,92,83,28,77,181,153,186,240,75,147,154,233,226,66,106,30,95,16,242,168,108,71,226,182,57,3,177,84,119,64,117,133,158,21,116,195,97,27,71,22,115,89,104,200,92,65,127,249,41,26,214,14,91,106,202,149,161,115,243,26,145,14,76,31,173,150,15,229,37,247,23,28,29,56,40,219,180,113,59,230,24,58,240,82,39,2,92,65,200,32,149,176,69,112,70,185,242,52,58,83,192,252,220,4,66,94,119,240,73,40,141,26,49,102,6,251,115,24,180,170,137,197,23,202,43,232,196,104,68,162,117,174,75,163,24,13,71,30,102,37,164,129,97,133,78,86,84,42,136,191,29,200,168,70,195,228,81,172,45,133,120,216,128,162,248,90,113,195,206,212,219,59,184,185,204,161,110,20,98,201,7,60,27,190,203,215,90,185,13,183,194,210,123,18,114,251,221,144,53,64,52,116,168,39,95,3,26,75,187,206,79,127,229,191,209,84,151,10,216,88,151,155,117,205,157,141,172,205,1,215,215,86,203,160,154,231,61,229,140,182,71,151,141,223,24,56,131,247,85,118,80,188,181,198,137,164,84,167,123,18,47,158,83,40,237,32,132,166,229,6,102,42,39,118,240,196,208,216,48,221,252,67,223,76,50,17,221,75,241,84,11,158,188,9,215,74,126,152,54,211,209,142,182,197,51,164,149,134,184,125,172,120,194,56,206,15,204,244,123,222,94,143,136,63,16,156,54,22,1,6,67,195,179,38,169,251,175,9,89,208,71,200,75,142,231,78,13,110,163,103,31,102,93,224,164,197,98,114,198,168,135,179,151,239,209,196,220,133,146,113,48,249,188,40,54,94,178,84,15,21,231,191,201,69,94,234,99,124,158,109,18,112,14,22,118,242,76,206,209,106,105,223,73,145,163,126,87,243,149,99,37,175,211,94,59,156,44,195,164,77,94,53,109,103,221,101,201,171,255,251,136,233,227,212,5,94,135,167,196,39,157,243,48,51,239,61,40,130,25,17,28,198,159,89,182,183,193,136,155,4,60,30,75,24,54,161,110,109,147,217,140,180,54,18,115,193,242,9,8,40,187,158,109,242,22,154,106,14,164,87,218,181,175,91,109,179,246,23,64,211,181,97,211,6,205,122,81,26,167,214,237,198,70,3,239,182,37,7,13,77,39,198,175,247,156,31,235,119,85,145,78,197,230,31,140,244,159,127,185,91,206,28,61,227,252,103,170,208,241,146,74,154,43,82,11,184,53,90,57,147,246,212,106,149,56,144,232,161,106,47,96,55,180,72,129,191,147,232,181,45,133,134,234,251,72,126,35,59,119,164,17,51,65,28,57,81,220,82,77,223,32,216,137,132,3,73,236,120,8,109,140,199,99,50,85,85,158,83,236,158,122,227,179,213,81,120,139,192,187,56,70,133,232,61,213,132,153,84,186,38,215,123,64,45,0,115,98,236,102,209,210,207,219,7,161,217,142,129,140,198,115,115,3,1,185,195,239,191,164,49,51,238,218,153,90,199,73,129,206,207,162,13,70,162,139,51,191,5,14,153,249,40,208,130,224,213,155,24,33,82,58,41,82,120,177,100,58,182,64,103,92,231,180,154,79,199,245,83,16,207,46,91,19,217,206,86,108,11,176,43,56,39,61,28,59,113,54,35,197,6,185,139,216,202,108,231,107,193,237,182,55,79,255,1,73,118,36,121,65,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b81a07e-f5a5-43a1-b7b8-6c4fdaced4b6"));
		}

		#endregion

	}

	#endregion

}

