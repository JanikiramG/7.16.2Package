namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileConstsSchema

	/// <exclude/>
	public class FileConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileConstsSchema(FileConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("92a37fd3-69e6-42f0-916f-9be6698711d1");
			Name = "FileConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,209,65,75,195,48,20,7,240,243,10,253,14,143,157,244,16,215,180,89,215,34,30,220,214,13,193,131,224,212,115,210,188,206,96,151,150,38,83,138,248,221,77,170,160,140,93,156,167,192,203,255,189,252,194,219,27,165,183,112,223,27,139,187,203,48,8,3,205,119,104,90,94,34,108,176,235,184,105,42,123,241,132,226,186,109,195,224,61,12,70,237,94,212,170,4,99,185,117,71,89,115,99,96,165,106,92,52,218,88,227,2,62,52,154,76,124,13,108,223,34,144,225,222,0,215,18,106,165,95,124,232,96,76,135,92,54,186,238,97,189,87,114,136,111,92,231,195,141,132,43,208,248,54,148,207,198,211,56,159,47,226,85,70,162,162,136,200,114,69,41,201,103,116,78,162,136,46,211,168,200,147,108,145,142,207,135,95,120,193,173,123,235,68,129,111,61,42,72,254,36,40,180,85,182,255,135,227,103,192,81,13,203,69,25,87,78,131,24,17,89,125,105,132,215,200,52,66,167,41,127,107,124,123,203,183,8,175,216,25,229,214,5,77,5,246,25,161,242,171,58,105,75,143,223,147,214,157,146,119,110,244,161,16,51,86,10,150,112,194,88,66,9,75,243,132,8,41,57,225,148,197,52,19,73,57,205,103,131,112,244,17,6,31,159,202,202,111,174,140,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("92a37fd3-69e6-42f0-916f-9be6698711d1"));
		}

		#endregion

	}

	#endregion

}

