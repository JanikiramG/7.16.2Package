namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationServiceSchema

	/// <exclude/>
	public class ITranslationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationServiceSchema(ITranslationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8368303c-f5ee-4bf3-920a-9f76b46f2286");
			Name = "ITranslationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d72ca66-8680-4c3f-b4a0-15ba7a19db7c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,83,77,139,194,48,20,60,87,240,63,132,122,169,80,250,3,148,61,184,194,66,23,186,138,45,120,16,15,49,125,173,193,54,201,38,105,161,43,251,223,55,38,86,20,197,187,123,75,230,205,204,123,147,15,134,107,80,2,19,64,25,72,137,21,47,116,52,231,172,160,101,35,177,166,156,69,153,196,76,85,118,61,28,28,135,3,175,81,148,149,40,237,148,134,58,74,65,182,148,64,194,115,168,166,207,138,209,26,118,134,96,40,35,9,165,49,67,49,211,32,11,211,122,130,226,171,38,103,145,165,110,206,27,51,145,150,152,232,224,203,140,139,222,144,127,207,247,199,91,35,16,205,174,162,4,209,222,250,177,179,119,180,238,151,73,18,208,123,158,171,9,90,90,185,43,110,22,2,220,17,244,221,183,22,54,57,98,214,242,3,4,78,118,26,103,185,72,51,63,68,43,248,110,64,233,15,46,107,172,13,110,168,9,40,133,75,112,80,244,169,56,11,209,59,207,187,84,119,21,220,80,46,104,180,150,88,8,200,195,83,59,111,101,174,135,51,5,207,77,109,120,175,229,52,71,51,162,27,92,209,31,184,74,30,140,167,47,27,234,254,2,123,53,154,9,81,117,255,63,230,124,15,228,240,40,230,8,88,238,158,176,221,255,186,239,117,3,26,236,15,8,245,149,191,227,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8368303c-f5ee-4bf3-920a-9f76b46f2286"));
		}

		#endregion

	}

	#endregion

}

