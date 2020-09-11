namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationActualizerSchema

	/// <exclude/>
	public class ITranslationActualizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationActualizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationActualizerSchema(ITranslationActualizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2bd260d-8139-4e57-b269-fae5dc20c315");
			Name = "ITranslationActualizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d72ca66-8680-4c3f-b4a0-15ba7a19db7c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,107,194,64,16,61,43,248,31,6,123,209,75,114,87,43,136,181,84,104,161,160,180,231,49,153,196,133,100,87,102,39,130,149,254,247,110,54,53,38,86,139,183,236,204,251,152,121,25,141,57,217,29,70,4,107,98,70,107,18,9,230,70,39,42,45,24,69,25,29,172,25,181,205,252,119,175,123,236,117,59,133,85,58,133,213,193,10,229,227,250,221,164,51,5,11,45,74,20,89,7,112,144,7,166,212,241,97,169,133,56,113,110,35,88,54,116,103,145,20,152,169,47,98,143,222,21,155,76,69,160,78,224,155,216,206,209,227,107,249,197,158,180,216,17,188,123,129,170,71,101,173,234,188,160,142,51,226,201,39,43,161,87,19,149,50,184,201,232,3,179,130,60,98,198,169,157,194,245,62,179,225,241,175,31,233,184,178,108,251,191,145,108,77,124,49,64,24,134,48,177,69,158,35,31,166,167,66,189,133,5,57,239,22,212,248,240,146,48,217,33,99,14,218,253,174,199,62,158,216,207,108,242,254,116,189,37,136,81,8,196,128,21,100,129,19,192,171,66,226,80,193,36,244,10,94,112,111,84,124,30,161,17,238,224,201,201,172,85,78,208,178,24,142,239,91,37,59,103,6,251,50,52,123,99,163,246,0,151,81,219,193,191,134,43,146,86,106,229,206,66,247,102,215,32,186,228,26,217,255,9,200,249,44,109,3,49,223,162,78,41,30,248,211,62,52,39,24,94,191,139,239,234,246,91,69,87,251,1,189,94,250,73,115,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2bd260d-8139-4e57-b269-fae5dc20c315"));
		}

		#endregion

	}

	#endregion

}

