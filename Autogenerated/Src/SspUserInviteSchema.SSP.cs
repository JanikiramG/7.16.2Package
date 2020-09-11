namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspUserInviteSchema

	/// <exclude/>
	public class SspUserInviteSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspUserInviteSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspUserInviteSchema(SspUserInviteSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0da7f03-8582-4036-b93e-8094a1fe6e41");
			Name = "SspUserInvite";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,77,107,195,48,12,61,175,208,255,32,232,61,185,183,219,160,148,81,10,163,132,102,61,141,29,220,68,201,12,137,29,100,123,163,148,254,247,249,163,159,219,200,210,236,18,98,161,167,247,158,100,75,176,26,85,195,50,132,23,36,98,74,22,58,154,73,81,240,210,16,211,92,138,40,77,147,225,96,55,28,220,25,197,69,9,233,86,105,172,39,195,129,141,140,8,75,155,2,179,138,41,53,134,84,53,107,133,180,16,31,92,163,79,136,227,24,238,149,169,107,70,219,199,195,217,86,215,140,11,36,40,36,65,35,73,179,10,184,199,68,71,72,124,129,105,204,166,226,25,100,142,227,154,2,198,176,184,12,120,189,22,225,196,158,180,37,36,27,36,205,209,10,76,124,41,175,236,135,52,31,120,170,25,175,64,22,71,89,198,150,142,78,217,151,170,142,178,148,38,215,149,0,220,65,137,122,2,202,125,246,45,52,201,185,122,104,71,166,23,121,59,207,220,240,252,156,251,31,38,16,118,228,157,76,45,109,98,47,38,123,71,166,121,205,197,90,240,110,198,174,1,157,57,221,228,129,100,133,234,111,142,215,55,159,190,114,217,189,76,133,255,105,150,73,35,186,185,250,134,184,205,150,173,130,66,97,247,105,61,7,64,239,161,29,116,206,73,154,166,147,189,107,64,47,206,101,87,115,174,37,55,57,91,161,50,149,118,79,217,61,255,176,201,90,137,54,82,86,144,154,44,67,245,237,126,192,3,104,50,56,105,219,27,68,118,151,125,190,243,10,195,42,179,154,187,237,13,15,252,197,212,8,69,30,54,152,63,135,232,117,112,255,5,184,121,3,70,188,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0da7f03-8582-4036-b93e-8094a1fe6e41"));
		}

		#endregion

	}

	#endregion

}

