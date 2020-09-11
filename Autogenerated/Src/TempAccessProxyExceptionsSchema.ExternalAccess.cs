namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TempAccessProxyExceptionsSchema

	/// <exclude/>
	public class TempAccessProxyExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TempAccessProxyExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TempAccessProxyExceptionsSchema(TempAccessProxyExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f12bace-72ee-4042-9a07-c5a18b5d88ca");
			Name = "TempAccessProxyExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f214e3c2-8cc2-4e62-be3f-96a9b4832c80");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,205,110,26,49,16,62,131,196,59,140,200,37,145,16,123,167,4,41,74,115,232,165,138,68,94,96,48,179,48,202,174,189,26,219,1,26,229,221,59,235,133,176,4,136,218,180,82,123,200,105,101,239,252,124,63,227,177,88,146,175,208,16,60,144,8,122,151,135,225,173,179,57,47,162,96,96,103,135,119,235,64,98,177,184,49,134,188,191,71,243,136,11,234,117,159,123,221,78,244,108,23,48,221,248,64,229,151,94,87,111,46,132,22,154,4,183,5,122,63,130,155,138,167,36,79,36,119,107,67,85,93,46,69,101,89,6,99,31,203,18,101,51,217,158,31,150,4,180,139,130,176,196,0,236,245,43,110,101,97,181,36,11,149,184,245,6,22,46,128,34,117,2,185,184,18,176,98,240,169,197,112,87,56,107,85,174,226,172,96,3,166,134,115,2,13,140,160,133,172,243,156,208,237,73,56,235,131,68,19,156,40,151,251,84,170,137,120,75,32,93,124,179,28,24,11,254,65,30,16,44,173,128,53,31,173,106,235,114,101,66,154,66,4,70,40,191,238,31,99,233,103,147,6,231,240,181,67,246,182,197,184,66,193,18,172,154,118,221,87,227,188,90,209,159,212,210,109,15,141,112,115,242,70,120,70,62,117,77,106,13,199,89,202,77,165,182,170,28,99,184,84,190,181,165,219,106,87,117,112,103,4,51,244,116,185,187,131,218,249,206,203,255,42,68,51,27,7,114,208,186,42,80,33,164,214,66,58,228,22,114,13,10,237,145,59,16,232,168,5,91,219,70,56,57,55,173,202,10,163,127,229,105,162,8,217,176,15,29,128,246,85,77,98,81,40,146,156,244,175,161,93,71,206,193,58,72,173,90,197,181,174,175,200,112,206,52,255,144,139,131,253,140,195,33,143,43,56,244,118,112,244,191,237,245,5,217,121,243,50,210,185,185,125,115,121,238,253,235,83,178,100,2,63,113,216,252,141,93,80,63,123,131,42,98,142,92,208,28,230,81,197,46,184,214,58,112,73,46,134,129,14,94,88,57,121,172,247,198,172,160,210,15,224,235,247,105,74,136,162,84,41,152,223,88,25,39,9,124,174,143,243,218,252,203,85,114,18,208,231,90,249,216,90,249,21,119,223,89,49,39,124,255,227,53,243,242,19,213,22,222,65,182,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f12bace-72ee-4042-9a07-c5a18b5d88ca"));
		}

		#endregion

	}

	#endregion

}

