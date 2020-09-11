﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImapSmtpMailboxValidatorSchema

	/// <exclude/>
	public class ImapSmtpMailboxValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImapSmtpMailboxValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImapSmtpMailboxValidatorSchema(ImapSmtpMailboxValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dc6e3865-0e37-42ce-a08e-3cabc6196187");
			Name = "ImapSmtpMailboxValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,201,110,219,48,16,61,43,64,254,129,80,47,18,106,200,247,56,49,144,56,105,43,160,110,2,216,237,165,237,129,145,70,54,1,137,20,72,42,75,139,252,123,135,139,108,122,81,225,92,2,101,230,205,246,222,12,205,105,3,170,165,5,144,37,72,73,149,168,116,54,19,188,98,171,78,82,205,4,63,63,251,123,126,22,117,138,241,21,185,107,40,171,209,171,37,45,116,118,187,188,159,108,92,57,215,176,114,17,215,45,203,230,8,124,20,47,183,2,35,248,105,168,204,56,101,133,173,168,19,3,230,162,132,122,139,13,7,144,48,100,207,62,97,239,66,178,176,202,22,97,10,12,217,179,5,240,18,36,186,17,240,65,194,10,155,34,179,154,42,117,65,242,134,182,139,70,183,190,193,31,180,102,37,197,50,22,59,30,143,201,165,234,154,134,202,215,233,230,127,0,82,72,168,174,226,124,63,40,30,79,9,107,218,26,26,224,218,206,78,42,33,109,141,95,166,8,49,50,16,5,242,9,164,253,198,96,80,89,159,121,28,148,250,121,11,21,237,106,125,195,120,137,19,37,250,181,5,81,37,7,37,211,17,249,134,155,64,174,72,60,52,74,156,254,198,132,109,247,88,179,130,20,102,236,193,169,201,5,185,161,10,246,205,35,114,80,23,51,254,181,28,109,9,21,92,105,217,25,141,144,215,7,91,206,33,124,233,161,162,201,119,100,4,163,57,20,150,178,174,72,47,200,35,182,145,224,23,49,75,28,189,249,82,168,163,171,182,91,122,14,122,45,74,83,85,10,141,89,160,116,126,203,42,227,107,144,76,151,162,240,178,29,155,48,251,12,218,29,73,205,80,59,183,106,175,168,167,237,191,207,74,4,10,39,89,9,36,63,4,147,163,41,18,63,65,36,65,119,210,175,157,247,153,162,151,135,33,211,132,195,115,72,231,181,92,117,102,163,146,184,219,97,42,30,217,204,209,46,127,105,58,121,23,101,129,80,199,249,58,208,62,243,95,176,120,229,197,90,10,206,254,216,101,239,233,114,114,207,36,148,216,52,163,181,242,120,132,228,188,18,100,32,60,241,117,250,203,232,153,123,162,146,80,174,158,241,102,174,136,165,102,48,179,11,136,114,103,71,56,50,8,214,246,102,73,137,52,234,228,65,38,109,177,205,228,115,155,30,130,252,61,216,114,236,15,205,183,151,125,21,43,198,71,129,255,1,165,125,22,178,12,48,189,169,135,185,151,200,106,126,93,162,48,74,5,224,67,103,31,246,69,40,29,0,113,111,22,246,17,241,176,36,237,129,15,66,30,5,26,251,22,133,205,46,84,29,224,156,97,211,164,166,82,47,235,157,214,188,201,33,60,153,150,66,134,87,237,214,23,225,7,219,157,231,27,247,52,137,239,235,210,78,23,252,56,244,59,28,17,50,184,245,129,74,241,40,212,44,61,33,24,15,86,200,57,146,68,87,96,194,13,112,239,231,193,244,120,23,194,146,244,148,204,251,199,72,246,238,240,132,20,181,89,33,140,52,107,234,239,214,28,46,254,45,168,46,214,36,177,173,189,20,208,218,151,17,250,175,254,52,34,119,23,217,118,225,43,164,5,38,59,78,63,149,145,199,53,183,20,110,41,102,212,165,253,184,77,220,131,195,86,252,203,229,178,77,72,240,184,188,247,189,176,226,155,45,127,239,75,177,9,28,122,35,124,143,6,178,4,165,253,20,73,143,250,207,139,232,172,187,198,183,127,160,249,209,59,93,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dc6e3865-0e37-42ce-a08e-3cabc6196187"));
		}

		#endregion

	}

	#endregion

}

