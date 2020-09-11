namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactSelectModelSchema

	/// <exclude/>
	public class ContactSelectModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactSelectModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactSelectModelSchema(ContactSelectModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c995aa53-261b-474b-b723-c7bbe16e4062");
			Name = "ContactSelectModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bb225b1d-9856-4e2d-8d05-b81de9745531");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,207,74,196,48,16,135,207,45,244,29,6,188,183,119,87,60,88,65,246,160,172,184,47,16,211,105,27,72,147,58,153,8,101,217,119,55,77,218,165,43,186,183,249,147,223,228,227,51,98,64,55,10,137,112,68,34,225,108,203,101,109,77,171,58,79,130,149,53,69,126,42,242,204,59,101,58,168,45,97,249,252,180,43,242,48,186,35,236,194,30,106,45,156,187,15,59,195,66,242,7,106,148,252,106,27,212,241,85,85,85,240,224,252,48,8,154,30,151,254,56,141,8,182,93,35,239,30,105,58,144,253,86,13,18,16,58,175,121,94,191,224,246,26,12,200,189,109,202,245,102,181,57,58,250,79,173,36,200,153,228,79,144,236,20,97,46,204,225,183,17,137,21,6,240,67,12,167,253,111,218,132,219,35,152,160,105,131,188,111,64,90,237,7,83,94,82,91,158,21,200,49,37,109,75,168,142,153,183,249,214,44,53,203,58,228,93,44,220,82,156,111,112,68,79,192,189,224,32,137,61,25,7,2,180,114,188,1,3,111,212,151,71,8,42,13,171,86,33,185,219,136,73,211,181,180,127,225,96,177,136,166,73,34,99,159,152,175,135,231,31,171,132,108,254,88,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c995aa53-261b-474b-b723-c7bbe16e4062"));
		}

		#endregion

	}

	#endregion

}

