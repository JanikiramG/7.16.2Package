﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExternalAccessRequestLogListenerSchema

	/// <exclude/>
	public class ExternalAccessRequestLogListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExternalAccessRequestLogListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExternalAccessRequestLogListenerSchema(ExternalAccessRequestLogListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b61b3cd4-1448-48b6-904d-b7f6096e5b0e");
			Name = "ExternalAccessRequestLogListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,86,219,110,219,56,16,125,118,129,254,195,84,45,80,25,27,208,239,190,4,72,84,183,53,208,108,139,56,221,125,88,44,22,52,53,182,185,149,72,151,164,156,120,3,255,251,14,169,75,44,53,110,154,2,5,218,23,67,34,231,114,206,204,153,145,21,207,209,110,184,64,184,66,99,184,213,75,199,18,173,150,114,85,24,238,164,86,108,122,227,208,40,158,157,9,129,214,126,224,226,19,95,225,211,39,183,79,159,244,10,43,213,10,230,59,235,48,31,117,222,217,28,69,97,164,219,221,93,172,50,189,224,217,112,152,232,60,167,192,239,244,106,69,199,119,247,135,8,188,197,253,55,6,217,84,57,233,36,218,7,13,216,116,139,202,121,59,178,124,110,112,69,132,32,201,184,181,67,104,243,186,196,207,5,90,71,152,222,73,130,175,208,4,159,193,96,0,99,91,228,57,55,187,211,234,189,54,128,165,54,240,242,88,152,151,128,30,196,14,48,64,96,117,176,65,39,218,216,34,242,204,106,16,6,151,147,232,235,68,216,57,183,24,206,118,225,160,134,18,193,192,199,251,235,158,171,120,46,214,152,243,223,169,207,48,129,232,24,220,168,255,55,5,216,20,139,76,10,16,190,66,15,22,8,134,112,4,14,69,186,13,229,107,106,254,90,98,150,82,209,63,24,185,229,14,203,203,77,249,2,214,145,210,4,24,228,169,86,217,14,102,148,4,254,201,232,103,2,244,120,193,21,41,206,176,55,232,179,211,83,220,97,17,245,71,85,54,84,105,153,176,157,96,171,101,10,201,26,197,167,132,171,50,220,92,103,133,151,119,172,23,255,162,112,96,201,21,77,31,188,172,123,189,45,55,117,251,38,16,151,12,251,165,201,168,49,40,44,26,26,21,69,238,158,226,164,242,96,31,91,231,165,125,219,150,189,58,175,167,99,170,104,6,144,213,224,166,55,116,238,240,253,6,203,233,139,163,47,16,7,182,189,222,190,93,224,11,116,107,29,42,28,90,88,94,118,213,27,14,222,114,149,102,104,107,126,115,190,197,180,20,41,107,124,6,93,167,241,134,27,158,131,34,21,77,162,178,16,209,105,232,121,85,57,54,30,4,147,251,61,48,58,189,90,99,208,122,173,243,225,81,165,7,92,103,75,234,112,72,112,102,86,214,235,27,164,34,161,40,218,84,66,43,199,165,242,115,239,214,88,39,12,20,32,229,142,183,176,84,146,214,91,74,39,211,74,11,239,213,76,81,71,28,133,104,11,224,4,202,244,231,72,195,141,77,126,192,90,25,11,82,60,59,116,175,253,176,63,250,49,210,145,75,136,31,146,15,141,198,183,138,167,38,210,51,232,10,83,229,216,135,223,55,5,149,198,148,115,142,233,249,110,150,222,33,163,12,87,187,13,166,9,5,202,213,31,60,43,112,236,237,79,227,232,242,208,163,82,103,64,221,14,245,108,210,161,205,146,194,24,10,239,73,251,111,142,227,194,205,210,6,31,178,153,77,124,191,51,244,56,156,41,176,12,221,243,171,129,253,201,141,138,95,68,222,25,110,191,18,216,47,190,61,121,75,138,226,180,23,17,53,238,232,110,131,107,233,214,16,193,111,101,166,222,139,67,118,132,226,182,197,105,95,179,13,77,165,15,169,165,82,147,149,194,107,90,92,130,103,242,63,190,200,112,78,217,73,41,29,144,151,104,117,97,4,221,106,67,110,39,199,119,115,179,229,79,42,84,209,23,193,45,155,41,161,137,53,149,208,218,194,195,187,40,225,36,124,19,210,133,150,53,120,221,218,232,235,128,179,81,210,141,192,96,25,87,60,250,7,210,216,127,251,62,249,184,161,17,244,163,249,211,173,148,206,76,31,219,41,117,54,90,45,143,220,41,53,245,71,174,148,35,31,166,234,139,52,58,92,59,77,134,206,214,121,68,127,94,209,60,253,210,253,249,254,157,95,83,255,113,253,105,50,220,223,159,206,255,147,242,180,125,72,103,255,3,135,152,195,116,147,11,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateIncorrectIssuedByMessageCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateIncorrectIssuedByMessageCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a11562cc-42e9-443d-b91d-cd15870af6dd"),
				Name = "IncorrectIssuedByMessageCaption",
				CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd"),
				CreatedInSchemaUId = new Guid("b61b3cd4-1448-48b6-904d-b7f6096e5b0e"),
				ModifiedInSchemaUId = new Guid("b61b3cd4-1448-48b6-904d-b7f6096e5b0e")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b61b3cd4-1448-48b6-904d-b7f6096e5b0e"));
		}

		#endregion

	}

	#endregion

}

