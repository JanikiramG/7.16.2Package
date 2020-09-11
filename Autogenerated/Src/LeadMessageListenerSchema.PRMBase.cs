namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadMessageListenerSchema

	/// <exclude/>
	public class LeadMessageListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadMessageListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadMessageListenerSchema(LeadMessageListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f408d242-9302-400c-8b6c-6d9552b53572");
			Name = "LeadMessageListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2b000645-6072-461d-8963-11edfee86881");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,203,110,194,48,16,69,215,65,226,31,44,216,208,77,62,0,212,77,163,62,144,40,173,120,124,128,113,110,130,69,98,83,79,92,21,85,252,123,199,78,168,120,45,44,121,102,206,157,185,30,123,210,166,20,203,3,53,168,39,253,158,143,225,10,206,73,178,69,147,102,214,225,63,221,82,233,106,235,32,115,78,164,43,73,59,186,171,170,107,107,174,117,153,173,42,168,70,91,67,233,43,12,156,86,215,200,76,155,47,206,245,123,70,214,160,189,84,184,232,106,10,93,122,39,67,139,126,239,55,112,201,208,161,228,80,100,149,36,26,139,25,59,123,7,145,44,49,211,220,146,167,68,108,239,55,149,86,66,5,234,30,36,198,226,73,18,110,164,9,79,73,146,112,78,131,94,52,170,156,39,125,58,253,45,27,196,238,201,16,38,111,235,93,124,114,197,111,109,156,87,141,117,172,136,30,90,160,243,115,199,201,104,77,112,172,51,237,170,132,191,8,31,216,232,134,141,142,174,211,209,103,242,198,77,172,59,44,213,22,181,156,243,14,197,163,24,156,13,233,234,131,201,45,189,64,1,7,163,192,223,228,107,115,46,158,230,157,224,228,177,85,172,167,57,19,1,136,207,164,52,92,151,93,165,21,204,129,60,219,66,237,158,127,162,84,225,163,88,64,89,23,148,188,24,68,236,120,187,196,46,119,185,215,227,31,115,56,84,154,173,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f408d242-9302-400c-8b6c-6d9552b53572"));
		}

		#endregion

	}

	#endregion

}

