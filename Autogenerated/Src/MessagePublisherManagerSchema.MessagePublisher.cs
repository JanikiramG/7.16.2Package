namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MessagePublisherManagerSchema

	/// <exclude/>
	public class MessagePublisherManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MessagePublisherManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MessagePublisherManagerSchema(MessagePublisherManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f427a0bd-0b35-4b26-946c-3c6a5598a4f9");
			Name = "MessagePublisherManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7c74fc90-4a57-4e68-9eda-fe0982d1250d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,82,77,107,194,64,16,61,175,224,127,152,226,37,130,228,7,216,218,82,148,138,7,139,80,123,46,107,50,209,45,113,55,204,110,4,17,255,123,103,179,241,35,17,11,165,151,108,102,242,242,222,155,55,171,229,22,109,33,19,132,37,18,73,107,50,23,143,141,206,212,186,36,233,148,209,221,206,161,219,17,165,85,122,13,31,123,235,112,251,216,170,25,159,231,152,120,176,141,167,168,145,84,114,193,92,211,18,114,159,191,244,8,215,140,134,113,46,173,29,194,28,173,149,107,92,148,171,92,217,13,210,92,106,46,169,130,22,190,153,64,226,145,247,129,226,80,129,207,196,111,10,115,38,94,144,218,73,87,139,138,34,84,64,40,83,163,243,61,124,90,36,158,85,7,239,240,85,54,234,250,175,30,234,52,176,54,37,24,104,29,149,137,51,196,66,149,203,90,38,56,190,227,53,106,137,54,53,251,224,195,22,162,101,5,70,112,227,77,136,227,239,6,231,232,54,38,189,164,208,12,193,172,190,153,10,166,232,102,60,135,212,9,70,60,142,95,88,21,245,59,95,139,1,76,84,165,38,105,255,20,62,14,32,156,207,144,113,194,169,157,72,39,79,158,151,251,2,193,249,199,8,252,59,95,5,231,207,232,76,216,175,108,11,66,87,146,14,208,135,17,232,50,207,225,5,94,89,138,157,25,138,199,188,32,135,103,91,30,55,104,47,103,208,48,48,172,72,254,22,202,237,198,118,70,165,80,239,235,191,97,236,36,193,182,117,3,56,151,104,214,190,22,253,235,13,92,169,93,81,134,212,84,6,209,13,99,29,223,73,85,180,1,241,105,156,154,228,120,63,162,208,109,54,185,247,3,34,107,219,148,32,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f427a0bd-0b35-4b26-946c-3c6a5598a4f9"));
		}

		#endregion

	}

	#endregion

}

