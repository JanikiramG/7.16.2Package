namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISspUserInvitationSchema

	/// <exclude/>
	public class ISspUserInvitationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISspUserInvitationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISspUserInvitationSchema(ISspUserInvitationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c32a2df7-dfa5-4008-a507-49930a3bf59e");
			Name = "ISspUserInvitation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,148,81,107,194,48,20,133,159,21,252,15,23,124,111,223,231,24,200,16,41,12,17,59,159,198,30,98,122,219,5,210,164,220,36,27,34,254,247,37,173,206,185,57,91,187,151,208,134,47,231,220,211,219,92,197,74,52,21,227,8,207,72,196,140,206,109,244,168,85,46,10,71,204,10,173,162,52,93,142,134,187,209,112,224,140,80,5,164,91,99,177,156,140,134,126,103,76,88,120,4,18,101,145,114,47,114,7,73,106,170,181,65,74,212,187,176,181,64,77,86,110,35,5,7,113,4,47,114,131,224,50,136,227,24,238,141,43,75,70,219,135,227,198,172,100,66,130,206,161,210,100,153,4,231,143,70,95,116,252,29,55,150,66,157,205,137,29,20,104,39,96,194,178,175,43,185,172,191,60,201,130,143,111,25,183,73,246,135,193,220,137,236,4,253,199,2,148,255,250,215,99,44,60,209,203,194,247,105,154,149,66,173,149,104,137,114,78,118,54,11,221,3,210,18,205,21,241,151,215,154,91,5,172,87,140,230,121,202,185,118,170,37,199,15,244,182,32,254,239,68,101,176,67,71,158,26,178,119,99,14,5,206,73,187,234,122,160,115,178,151,217,162,53,78,72,127,83,150,21,26,39,109,184,139,186,194,195,140,184,236,176,209,90,66,234,56,71,211,189,249,51,34,77,240,241,38,36,250,113,225,135,131,47,178,229,166,215,39,126,235,55,235,24,85,214,140,169,240,186,255,4,254,4,5,176,240,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c32a2df7-dfa5-4008-a507-49930a3bf59e"));
		}

		#endregion

	}

	#endregion

}

