namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationLoggerSchema

	/// <exclude/>
	public class TranslationLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationLoggerSchema(TranslationLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5a3f11c0-05c4-491f-b69b-c36875a97219");
			Name = "TranslationLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,219,106,194,64,16,125,142,224,63,12,246,37,66,201,7,40,34,69,164,4,42,72,107,159,203,26,199,52,37,217,13,179,27,169,136,255,222,201,238,122,201,69,232,83,230,114,230,156,153,179,145,162,64,93,138,4,97,131,68,66,171,189,137,22,74,238,179,180,34,97,50,37,163,13,9,169,115,27,15,7,167,225,32,168,116,38,83,248,56,106,131,197,244,154,167,185,218,138,124,50,89,168,162,224,169,55,149,166,92,190,245,239,233,9,31,213,239,213,24,195,168,39,194,148,19,88,228,66,235,9,220,245,107,9,36,11,42,171,109,158,37,144,212,152,46,4,38,16,247,204,5,39,59,123,83,80,82,27,170,18,163,136,133,214,150,210,33,60,125,135,35,252,212,72,60,38,49,169,139,80,53,210,49,212,110,5,65,11,52,107,193,106,43,130,179,95,5,229,206,109,211,92,109,77,170,68,50,25,214,139,81,118,16,6,253,102,46,129,150,70,43,117,123,164,104,172,86,160,125,112,110,114,196,124,20,124,229,246,178,105,167,225,173,188,82,249,40,32,52,21,201,203,28,204,231,16,94,226,89,61,180,18,82,112,18,189,162,241,166,141,58,62,142,198,99,183,217,249,31,94,172,208,124,171,93,255,11,29,84,182,131,37,145,162,112,249,155,96,105,175,199,203,67,56,177,200,245,249,169,249,247,139,150,69,105,142,207,140,105,56,210,97,139,95,172,147,239,168,171,220,0,217,79,47,173,107,69,43,212,154,207,126,200,26,203,189,10,213,246,135,31,8,10,143,109,210,89,68,209,67,211,242,197,85,155,69,174,253,1,230,148,98,173,216,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5a3f11c0-05c4-491f-b69b-c36875a97219"));
		}

		#endregion

	}

	#endregion

}

