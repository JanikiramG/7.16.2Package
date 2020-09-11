namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFolderManagerServiceSchema

	/// <exclude/>
	public class IFolderManagerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFolderManagerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFolderManagerServiceSchema(IFolderManagerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c540fd1a-0f99-4be3-b6a9-232ced714c13");
			Name = "IFolderManagerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("be1f674b-cdb4-46e4-8c46-23cae20b9205");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,77,107,220,48,20,60,59,144,255,32,54,151,13,44,254,1,9,189,244,43,184,176,77,136,183,228,176,236,65,145,198,27,81,89,114,37,121,139,41,249,239,125,178,108,111,54,205,6,10,41,20,124,209,60,189,121,163,25,201,134,215,240,13,23,96,43,56,199,189,173,66,254,193,154,74,109,91,199,131,178,38,255,108,181,132,91,114,195,183,112,37,220,78,9,156,158,252,58,61,201,90,175,204,150,149,157,15,168,47,159,173,137,68,107,136,200,224,243,43,24,56,37,254,216,51,176,45,173,132,126,181,152,223,225,158,54,208,150,51,135,45,113,178,194,4,184,138,116,95,176,226,101,133,25,125,235,97,69,39,10,142,139,48,255,74,199,101,239,216,236,165,150,217,249,134,90,154,246,94,43,193,212,200,127,148,62,58,48,201,89,34,60,88,233,47,216,77,223,222,75,205,214,215,13,146,137,227,252,77,15,211,97,10,179,179,223,49,79,109,81,208,205,117,185,154,45,216,55,167,86,168,27,205,67,47,147,250,118,112,33,41,160,242,123,43,187,50,116,58,22,137,101,9,239,73,212,132,230,119,142,55,13,228,130,197,57,217,45,126,180,240,212,237,106,30,14,58,18,148,127,241,214,44,216,45,93,0,74,9,175,239,235,205,201,118,86,73,118,160,106,126,213,18,100,240,51,45,11,26,222,35,13,119,48,97,15,250,224,98,184,132,169,208,149,226,1,53,143,97,156,95,190,149,87,133,17,186,149,248,20,7,40,248,194,252,173,107,131,93,139,127,229,221,193,179,26,238,209,216,207,142,168,159,15,182,121,219,58,129,189,109,147,159,146,68,42,147,40,247,213,254,8,7,142,211,115,108,107,19,139,35,117,63,170,27,210,170,158,231,84,41,77,15,192,39,205,111,23,210,71,104,4,252,111,201,60,85,53,37,242,20,60,30,67,116,111,189,97,14,194,58,233,71,163,206,96,100,250,51,208,234,49,253,184,38,136,30,231,227,111,64,55,66,23,119,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c540fd1a-0f99-4be3-b6a9-232ced714c13"));
		}

		#endregion

	}

	#endregion

}

