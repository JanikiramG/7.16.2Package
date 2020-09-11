namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationLoggerSchema

	/// <exclude/>
	public class ITranslationLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationLoggerSchema(ITranslationLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fee74088-6ba4-462a-9370-fec3c8e1fb8d");
			Name = "ITranslationLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,65,10,194,48,16,69,215,10,222,97,192,77,221,244,0,118,37,210,69,65,65,212,11,196,116,26,35,109,166,76,18,81,138,119,55,166,40,81,92,37,127,254,155,63,147,24,209,161,237,133,68,56,34,179,176,212,184,124,77,166,209,202,179,112,154,76,126,100,97,108,27,239,179,233,48,155,78,188,213,70,193,225,110,29,118,197,71,167,237,140,105,87,96,2,53,103,84,65,64,101,28,114,19,6,46,161,74,160,13,41,133,28,201,222,159,90,45,65,191,193,191,220,100,136,236,39,118,139,238,76,181,93,194,46,118,143,230,149,116,13,37,51,113,86,222,36,246,175,0,192,69,241,227,85,43,249,114,246,104,125,235,128,227,145,64,149,105,40,163,211,5,165,131,240,89,86,168,24,17,167,163,169,199,5,162,126,140,47,253,42,134,218,19,69,103,9,128,100,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fee74088-6ba4-462a-9370-fec3c8e1fb8d"));
		}

		#endregion

	}

	#endregion

}

