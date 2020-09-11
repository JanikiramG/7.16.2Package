﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OrderVisaNotificationProviderSchema

	/// <exclude/>
	public class OrderVisaNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OrderVisaNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OrderVisaNotificationProviderSchema(OrderVisaNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e");
			Name = "OrderVisaNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2a4b8a43-1fe2-457d-94c6-a637032531ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,75,111,227,54,16,62,103,129,253,15,132,123,145,1,67,105,175,155,108,0,231,9,23,155,56,141,157,237,97,17,44,20,137,201,178,144,41,151,164,178,117,131,252,247,14,159,34,245,178,210,77,90,180,216,83,34,114,158,31,135,51,163,145,105,178,194,124,157,164,24,45,49,99,9,47,238,68,124,84,208,59,114,95,178,68,144,130,190,125,243,248,246,205,78,201,9,189,71,139,13,23,120,181,87,123,6,250,60,199,169,36,230,241,25,166,152,145,180,162,241,197,50,220,181,30,31,31,118,110,157,80,65,4,193,28,8,128,228,7,134,239,65,19,58,202,19,206,223,161,57,203,48,251,72,120,114,81,8,114,71,82,101,243,37,43,30,8,172,43,134,117,121,155,147,20,165,146,190,159,28,189,67,135,9,199,109,91,19,52,243,151,65,236,163,18,94,153,3,206,139,132,10,48,233,146,145,135,68,96,189,191,214,15,40,149,251,136,11,38,29,60,187,154,95,95,126,190,152,158,159,160,247,104,36,205,25,237,117,18,91,50,101,122,15,157,115,109,145,126,193,171,228,2,14,214,177,109,81,161,104,90,216,70,123,198,73,76,51,237,103,232,244,41,193,121,214,229,49,195,73,86,208,124,131,206,74,146,161,207,124,195,167,217,138,208,107,74,196,22,177,10,75,86,166,162,96,82,184,58,63,35,91,159,101,239,41,70,199,68,197,98,194,54,251,218,191,9,42,110,127,131,0,61,64,235,132,129,127,2,51,62,150,226,118,222,161,91,56,240,200,91,70,143,106,35,48,23,240,136,164,19,99,241,133,240,184,34,254,52,242,169,102,217,232,70,65,252,244,12,91,175,57,102,224,46,213,215,7,149,193,99,96,99,109,75,219,249,212,15,36,168,89,99,38,239,78,8,227,238,238,46,218,231,229,106,5,24,29,216,133,51,86,148,107,68,193,183,216,209,236,250,68,198,33,27,195,138,92,163,117,143,133,249,111,135,97,81,50,234,69,184,130,68,26,234,172,109,213,238,238,224,96,3,84,164,118,233,111,215,220,133,211,57,22,95,138,206,64,94,96,153,221,208,25,22,11,255,184,233,85,145,99,189,23,217,176,121,72,24,226,154,252,61,162,248,171,225,173,29,179,62,215,29,153,55,203,21,141,70,139,48,138,250,182,165,78,143,228,148,21,171,26,191,50,203,17,252,250,5,51,220,212,16,207,248,201,239,101,146,71,90,71,124,105,99,58,10,2,127,60,70,9,55,62,104,52,13,188,188,90,122,10,193,250,165,196,108,115,4,1,43,241,114,15,1,64,191,59,18,141,145,71,181,231,136,32,63,101,68,130,117,74,24,23,1,165,221,137,194,199,229,102,141,193,175,139,50,207,173,182,157,15,248,78,156,252,177,102,152,115,121,206,129,20,233,120,181,167,48,146,199,100,0,156,32,183,96,225,126,210,214,57,243,227,105,150,1,190,116,6,53,48,10,237,157,244,40,106,201,211,19,93,4,230,95,169,86,55,174,107,58,201,57,126,9,63,130,67,116,226,219,206,209,222,114,44,142,225,49,50,143,25,252,47,200,10,251,199,41,215,206,147,148,21,28,236,10,3,29,186,1,241,161,72,147,156,252,153,220,194,101,81,66,162,81,111,74,148,22,31,59,145,35,47,36,192,195,50,151,161,0,10,30,32,173,197,203,66,18,46,193,158,200,25,22,120,168,57,128,206,104,174,76,29,247,251,124,88,100,155,182,58,162,255,30,160,204,109,105,252,63,38,121,137,185,143,202,45,72,88,226,213,58,151,130,95,10,151,67,79,168,143,12,45,87,183,144,58,223,119,216,245,105,180,36,2,98,225,102,47,56,52,9,92,15,143,196,214,103,73,210,180,40,169,232,225,152,106,10,159,9,174,133,72,210,62,166,35,77,97,153,188,64,3,38,27,126,214,220,113,195,28,195,174,33,4,14,205,31,159,22,108,149,136,104,244,248,227,211,4,61,254,244,4,232,25,134,137,181,201,200,34,119,40,210,220,38,121,204,217,201,106,45,54,145,161,31,187,100,210,161,209,136,243,170,77,183,76,171,122,155,76,179,236,203,180,65,213,240,209,143,180,137,9,133,137,2,112,210,10,82,120,69,36,183,127,23,6,148,200,66,64,20,227,204,222,29,243,136,10,184,147,12,34,213,171,151,178,155,174,85,72,163,118,107,109,84,149,173,37,85,214,46,110,67,249,67,1,205,38,36,102,29,100,60,50,198,232,130,101,141,80,29,41,20,186,217,42,185,55,97,230,95,57,181,220,158,167,169,172,46,38,82,149,200,176,86,183,231,118,85,113,167,60,26,53,139,123,59,195,92,181,171,228,1,27,62,239,121,8,251,66,36,162,228,78,107,245,56,200,88,126,148,208,20,124,115,70,123,11,67,4,4,149,76,27,208,219,223,52,90,144,218,219,200,88,11,9,245,180,154,18,152,113,161,46,130,177,64,231,191,173,60,206,98,229,131,2,189,3,182,128,77,101,74,205,168,255,173,53,112,54,47,74,171,148,237,138,212,174,214,169,109,66,12,169,237,234,223,3,175,27,184,134,0,123,45,12,167,250,223,181,14,91,238,221,207,5,161,75,89,209,58,238,93,112,101,102,112,229,153,228,104,216,28,207,59,15,199,246,173,29,247,70,174,122,39,38,219,191,121,41,140,154,10,113,169,192,63,149,166,232,64,172,161,236,22,236,14,71,9,246,14,112,139,96,67,57,20,94,149,214,76,155,217,147,217,62,221,160,59,66,147,60,223,232,155,143,101,99,230,231,183,107,65,114,53,81,145,125,200,169,38,85,88,26,242,122,74,246,243,157,121,163,216,154,120,64,95,4,174,55,3,140,71,53,227,198,22,212,41,205,134,228,164,206,87,151,187,4,186,228,241,80,36,167,42,161,74,79,79,73,46,217,219,240,236,22,19,140,131,102,244,174,144,69,228,10,167,5,203,234,59,223,214,72,10,153,186,94,172,131,84,137,176,222,66,170,114,72,244,69,175,86,226,37,219,0,184,240,90,214,213,186,217,220,112,51,65,69,41,172,132,176,191,144,133,190,1,149,105,126,150,198,53,229,226,68,175,29,234,22,199,246,224,29,248,24,98,99,0,208,27,221,102,93,77,12,55,106,67,234,151,222,116,58,17,164,250,155,113,32,33,24,137,245,9,240,242,235,141,145,112,14,239,99,214,186,173,70,248,170,23,225,228,105,43,111,173,186,58,57,106,64,99,108,87,255,123,47,177,131,155,189,109,67,163,43,117,202,28,81,239,136,59,166,55,106,69,71,5,63,240,67,34,222,223,181,203,222,148,103,118,2,173,44,102,50,186,247,27,151,237,160,222,178,241,122,131,89,223,151,92,60,10,147,131,86,20,102,134,5,22,182,117,252,64,184,216,183,23,53,213,139,86,139,121,148,35,0,221,214,237,53,151,77,211,209,178,115,236,93,190,96,195,85,168,150,61,87,100,90,246,194,126,165,133,192,111,0,90,182,219,171,124,13,159,234,245,88,231,185,43,245,118,253,31,122,77,22,126,242,123,221,148,170,222,202,253,160,205,122,50,136,155,28,255,223,94,230,37,19,174,114,241,176,20,92,177,242,33,233,215,79,189,21,43,113,149,97,107,241,10,113,252,62,116,120,205,161,131,148,183,46,214,229,218,20,182,75,249,63,128,157,184,244,29,54,5,78,69,208,28,72,229,195,59,0,27,128,221,149,189,138,51,127,206,171,103,249,140,200,132,128,47,141,209,202,248,120,97,151,163,176,217,9,49,18,21,62,65,38,152,212,196,186,164,187,179,211,150,118,171,113,138,253,16,90,27,169,216,198,181,227,227,132,142,232,238,79,23,218,131,153,70,228,60,161,0,35,147,35,237,125,31,169,3,84,200,60,232,47,53,19,168,191,107,4,197,240,122,145,73,105,135,27,137,111,227,85,47,24,250,41,21,71,201,90,232,25,119,67,99,108,246,188,174,245,91,135,56,175,248,190,84,125,9,241,63,120,132,95,69,106,105,210,157,237,51,190,30,117,143,156,134,208,29,49,12,17,154,205,233,179,200,15,55,67,229,159,23,25,192,56,92,129,165,31,174,1,74,113,10,173,182,108,214,228,79,15,248,179,39,108,33,185,59,43,111,16,100,135,89,195,198,103,211,60,47,190,226,108,89,28,195,233,221,183,204,131,218,25,45,117,38,39,159,67,181,61,111,180,7,189,237,112,92,23,186,10,62,127,104,56,40,142,138,213,10,55,103,95,223,71,129,47,57,10,84,47,241,170,5,104,224,38,191,149,14,152,196,154,122,86,151,33,185,7,205,18,253,132,222,176,193,172,255,123,19,77,195,118,12,153,131,80,89,9,205,66,231,167,7,189,255,79,76,46,125,29,93,117,189,57,91,247,191,252,75,25,243,97,35,122,107,89,83,150,254,120,220,241,227,131,198,20,52,252,240,236,236,80,51,209,182,143,210,86,220,112,3,122,148,191,216,108,247,53,134,187,38,176,250,70,167,181,35,161,145,177,166,187,13,232,253,125,200,214,95,134,188,192,111,67,28,96,221,131,219,111,26,8,191,216,68,184,227,71,44,97,203,213,51,23,211,171,254,226,211,95,23,191,44,180,55,41,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBodyTemplateLocalizableString());
			LocalizableStrings.Add(CreateTitleTemplateLocalizableString());
			LocalizableStrings.Add(CreateDateMacrosLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBodyTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("55671414-7004-4655-bd33-f33694187f1b"),
				Name = "BodyTemplate",
				CreatedInPackageId = new Guid("f47b7eb4-25f2-40e9-8029-0cf09a9ad463"),
				CreatedInSchemaUId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e"),
				ModifiedInSchemaUId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTitleTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("698137bc-ada1-4693-9f2d-ead1f73c1dd1"),
				Name = "TitleTemplate",
				CreatedInPackageId = new Guid("f47b7eb4-25f2-40e9-8029-0cf09a9ad463"),
				CreatedInSchemaUId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e"),
				ModifiedInSchemaUId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateMacrosLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2fcf728c-3ce9-43be-a65e-d4baccb54593"),
				Name = "DateMacros",
				CreatedInPackageId = new Guid("6e7e08a6-1dd2-4d95-aa5c-0c8e6a3dc851"),
				CreatedInSchemaUId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e"),
				ModifiedInSchemaUId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e"));
		}

		#endregion

	}

	#endregion

}

