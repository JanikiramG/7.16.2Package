namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DocumentConstsSchema

	/// <exclude/>
	public class DocumentConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DocumentConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DocumentConstsSchema(DocumentConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c6fbe5f3-8af5-45bb-b253-d7c21e1e0cb2");
			Name = "DocumentConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,144,193,106,195,32,24,128,207,13,228,29,164,167,237,224,80,163,38,82,118,48,38,25,59,237,176,190,128,51,182,4,18,45,106,24,101,244,221,103,183,91,119,216,96,135,255,224,207,231,247,193,239,244,98,227,73,27,11,246,54,4,29,253,33,61,40,239,14,211,113,13,58,77,222,149,197,71,89,108,214,56,185,35,120,61,199,100,151,93,126,111,242,156,214,183,121,50,32,166,204,25,96,102,29,35,232,188,89,23,235,82,86,196,20,51,116,253,124,67,6,171,71,239,230,51,120,90,167,17,100,50,5,109,210,243,8,30,129,179,239,95,219,187,109,37,90,210,112,66,161,104,122,14,187,1,99,40,106,220,66,132,112,199,81,47,170,70,241,237,253,238,55,187,252,33,230,120,168,37,171,43,200,200,127,196,202,135,144,15,231,221,104,157,177,55,13,162,90,166,164,194,16,51,82,193,30,229,134,20,84,94,27,140,117,136,86,4,209,63,52,94,194,104,195,141,186,105,91,49,48,165,178,16,245,144,214,245,0,5,85,12,114,34,59,129,186,158,43,37,191,213,151,178,184,124,2,232,178,79,191,222,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c6fbe5f3-8af5-45bb-b253-d7c21e1e0cb2"));
		}

		#endregion

	}

	#endregion

}

