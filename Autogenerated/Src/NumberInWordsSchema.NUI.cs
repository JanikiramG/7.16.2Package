﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NumberInWordsSchema

	/// <exclude/>
	public class NumberInWordsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NumberInWordsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NumberInWordsSchema(NumberInWordsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("09a87c67-bcd5-4ac6-b1fe-80bc8a216ea8");
			Name = "NumberInWords";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,61,107,111,28,71,114,159,105,64,255,161,111,22,198,205,90,171,37,41,219,8,44,62,0,71,103,7,2,34,39,176,148,228,131,32,4,75,114,40,45,188,220,37,102,119,37,19,6,1,153,138,237,4,50,78,137,97,59,135,131,124,182,14,193,37,31,105,153,148,41,74,162,254,194,236,63,74,191,187,170,31,243,88,46,69,242,64,249,142,59,211,143,170,174,234,234,234,234,234,234,158,97,191,221,189,69,174,109,244,7,201,218,220,185,55,134,224,181,121,61,249,116,160,211,174,39,105,218,234,247,86,7,205,203,189,52,105,126,208,29,180,7,237,164,111,215,185,220,235,116,146,229,65,187,215,237,55,255,46,233,38,105,123,57,167,8,205,58,247,70,183,181,150,244,215,91,203,9,194,209,93,109,223,26,166,45,86,236,220,27,159,157,123,99,106,125,184,212,105,47,147,254,128,166,45,147,229,78,171,223,39,31,13,215,150,146,244,74,247,95,122,233,74,159,150,97,229,172,130,253,65,202,112,83,128,119,146,116,240,254,90,111,216,29,92,239,125,60,92,186,54,72,227,149,100,185,189,214,234,144,22,79,174,19,94,255,78,43,37,253,37,178,64,186,201,93,114,141,87,255,219,97,187,179,146,164,113,125,142,21,200,30,143,238,103,47,232,127,219,205,236,199,209,189,236,32,123,149,237,141,62,31,125,29,11,56,13,146,125,147,109,103,207,71,191,31,109,177,50,63,209,226,63,103,207,179,189,6,133,43,64,164,201,96,152,118,233,107,243,122,79,160,16,176,55,25,67,202,145,112,181,213,73,142,128,134,236,191,178,221,236,215,236,143,60,101,151,254,183,31,160,234,127,89,121,74,213,65,246,104,76,186,238,244,218,43,138,170,15,219,221,86,119,57,161,178,49,92,235,246,175,247,120,143,198,131,219,237,62,225,162,182,65,18,254,211,32,87,62,232,14,215,146,180,181,212,73,230,5,103,22,73,151,203,129,168,252,17,19,39,220,88,178,60,76,211,164,187,188,209,96,141,248,112,216,93,150,53,27,68,65,184,149,12,68,123,13,144,178,172,92,165,227,161,181,124,155,196,172,164,221,18,210,238,186,173,171,115,192,83,43,61,202,142,68,118,28,69,32,40,164,195,102,112,125,99,61,89,17,21,254,185,213,25,38,243,162,232,98,108,131,18,45,40,33,145,154,3,186,171,166,164,88,245,45,178,105,67,60,204,8,97,150,109,190,150,12,64,115,99,27,102,3,75,132,106,192,82,243,114,39,105,41,62,110,150,145,147,43,221,193,71,160,37,121,146,194,0,149,19,22,62,32,78,178,188,144,137,11,140,30,189,69,2,211,204,254,68,11,190,164,37,158,208,191,219,163,135,217,119,217,78,182,71,159,247,70,95,102,219,167,67,158,164,32,81,190,175,244,186,157,13,217,198,27,55,89,74,135,179,88,246,151,206,224,12,143,34,46,0,83,17,165,120,151,114,231,225,104,75,165,80,158,28,128,183,173,209,3,158,255,85,246,210,173,67,57,5,243,89,179,248,196,151,35,230,191,91,234,28,141,152,87,18,230,211,33,206,28,22,229,27,165,166,181,204,56,199,171,72,217,80,226,156,38,171,82,82,79,186,172,250,133,194,75,28,98,160,160,17,245,16,163,152,129,20,236,246,106,56,197,144,97,155,118,1,85,174,20,60,101,66,204,94,235,2,174,104,175,238,36,105,196,93,109,13,110,55,63,166,105,43,146,197,228,77,50,219,32,239,72,242,24,180,180,213,253,132,86,152,17,41,84,76,72,60,39,18,23,201,133,119,196,227,133,11,74,24,166,218,171,4,128,34,11,180,166,206,155,90,162,50,246,137,0,196,121,101,90,244,214,2,153,149,40,54,13,37,130,81,46,37,176,243,41,181,239,175,172,8,134,209,146,81,36,155,78,219,33,25,65,219,49,195,26,50,171,27,98,215,161,42,112,151,106,81,170,22,101,237,41,197,88,154,27,178,151,190,135,205,77,58,253,36,31,58,85,29,95,84,128,254,72,67,231,191,98,252,94,225,125,23,26,194,57,211,129,224,68,165,233,128,86,209,227,76,96,167,189,145,135,157,113,156,203,197,60,232,114,14,167,249,254,250,122,66,69,44,34,145,44,139,211,33,195,52,78,213,191,20,43,228,166,86,245,55,102,200,5,46,124,55,231,140,228,73,129,113,123,124,10,129,57,79,123,5,246,118,133,238,86,114,11,59,220,5,14,59,187,66,111,235,238,206,233,74,65,98,165,174,164,85,12,223,233,139,183,63,64,58,36,167,142,229,144,42,60,89,72,244,160,79,35,58,208,97,37,134,198,174,100,212,166,111,117,104,172,98,177,52,100,53,166,167,167,201,124,127,184,182,214,74,55,22,85,66,77,255,35,232,151,232,119,245,64,83,230,215,91,105,107,141,233,90,182,112,93,136,210,164,63,236,12,162,233,69,226,64,105,106,140,211,16,37,110,43,214,216,86,159,169,197,29,125,145,164,88,43,27,218,119,250,165,97,193,18,45,211,179,173,2,165,85,22,21,43,174,198,63,236,244,122,105,108,80,72,230,115,69,154,237,240,246,252,44,36,68,43,212,24,20,167,163,201,192,172,147,183,232,16,154,209,131,49,44,142,166,78,3,81,81,40,150,146,44,209,72,185,224,204,190,229,141,220,166,117,152,177,245,181,94,191,62,203,246,179,189,24,83,209,176,184,6,1,122,39,225,188,46,242,172,151,207,58,45,175,211,100,183,177,87,53,184,33,190,199,20,198,47,28,197,231,28,218,54,235,206,24,227,250,22,146,103,99,194,196,215,1,74,46,41,2,179,214,30,167,78,33,8,147,111,18,162,37,33,149,146,44,94,3,50,134,201,11,1,92,176,41,117,115,106,54,140,6,1,37,40,242,217,139,111,191,211,124,119,182,89,44,199,64,140,133,224,82,105,86,89,134,156,191,14,69,148,182,239,180,6,73,64,54,242,145,121,120,56,182,180,224,1,251,91,242,91,75,42,240,56,193,207,13,82,179,68,132,88,37,225,240,176,117,3,106,191,177,0,162,153,153,72,153,14,211,211,168,206,135,189,116,173,53,32,113,244,217,204,165,153,153,205,168,161,80,5,212,143,164,230,4,169,165,98,197,212,128,3,205,12,36,123,248,25,64,73,66,150,169,142,90,136,4,167,85,49,53,89,41,120,117,170,183,2,90,138,167,164,9,125,255,164,143,27,4,199,186,221,173,196,213,4,166,46,177,234,33,112,80,91,218,104,231,5,219,250,14,99,124,242,167,153,211,29,118,58,8,168,129,225,245,184,75,69,241,36,219,165,191,98,132,73,147,114,116,223,51,203,171,177,194,214,19,64,69,177,85,141,176,149,101,95,71,198,48,165,98,65,17,60,207,158,50,177,32,217,207,212,252,167,88,8,125,219,101,254,37,142,246,75,38,108,124,33,248,53,215,70,207,154,145,18,158,202,230,129,170,224,106,214,124,211,64,33,100,164,1,248,150,80,147,223,44,216,114,174,86,58,69,164,243,97,181,195,25,253,84,12,46,206,4,202,18,94,104,151,61,238,100,79,70,247,71,95,176,214,237,141,254,109,116,143,80,93,119,192,7,40,205,252,149,142,196,87,220,219,166,56,4,22,31,18,59,235,255,242,67,204,213,105,196,18,171,74,211,58,150,41,219,192,239,230,104,102,163,131,197,20,99,212,18,85,84,157,141,203,173,245,126,108,129,237,218,83,139,103,241,93,167,101,254,155,150,225,106,141,205,113,163,7,217,110,51,251,129,118,194,86,253,240,108,58,98,166,248,26,47,164,0,37,29,33,239,92,92,39,77,182,132,133,119,38,90,213,120,114,146,37,75,242,205,102,27,154,137,173,25,216,94,185,16,155,173,77,5,112,218,130,56,159,124,218,90,91,239,36,8,131,177,28,102,141,13,162,18,235,115,132,150,227,38,70,228,175,116,49,175,82,168,78,62,38,77,73,164,9,177,26,94,64,200,187,162,35,106,214,63,18,203,226,14,242,134,36,81,254,154,135,90,84,23,27,98,186,113,178,174,183,105,94,159,149,22,163,115,50,156,33,119,136,4,151,167,40,23,36,231,217,118,124,29,43,23,177,162,213,139,33,251,174,97,115,171,73,1,242,250,33,112,209,98,110,1,185,104,94,116,109,72,146,135,67,153,112,57,139,112,108,231,73,113,88,78,214,89,100,137,52,137,223,79,111,13,215,146,238,224,3,149,30,33,70,251,153,64,60,218,72,3,30,219,207,247,149,234,254,6,185,130,151,16,217,31,168,94,120,193,45,164,93,158,246,144,208,135,189,252,101,155,84,130,73,154,246,82,230,69,118,13,90,45,111,177,193,13,252,242,162,38,181,235,152,237,36,205,216,193,237,180,119,151,15,25,135,113,162,60,29,14,6,88,228,245,31,216,28,5,226,139,151,141,146,51,77,99,89,107,200,100,126,129,176,53,110,243,106,235,83,190,45,166,173,77,139,187,194,55,0,121,43,56,135,22,240,155,132,123,230,61,40,58,189,238,173,18,56,88,177,146,72,36,136,171,27,184,239,214,54,174,169,157,86,43,43,182,252,103,218,144,95,105,223,161,230,249,140,101,246,155,246,79,51,235,125,70,57,235,45,215,229,99,54,11,141,238,141,254,157,190,127,145,253,81,44,111,197,2,55,150,128,27,132,254,143,181,43,0,194,84,218,142,149,11,198,96,191,160,219,247,150,104,135,98,10,128,184,121,168,133,240,81,43,192,130,117,174,163,7,27,112,122,5,171,110,42,62,191,227,166,7,94,95,31,131,202,60,180,242,51,36,2,107,163,4,173,88,57,30,66,125,219,206,128,213,78,175,53,32,144,108,91,10,136,48,251,26,80,90,44,51,83,64,209,205,181,179,221,10,14,34,212,15,164,134,37,21,10,138,108,141,246,101,145,56,250,152,25,14,166,185,179,127,19,182,120,33,245,99,56,142,255,154,39,152,147,52,61,24,29,69,251,147,151,193,178,2,114,47,34,201,105,158,136,233,69,72,203,217,236,2,127,15,57,187,84,86,118,21,70,183,16,176,73,15,238,215,48,158,14,47,170,130,116,35,169,142,120,158,73,231,177,75,39,219,136,154,180,112,142,47,50,150,88,163,72,51,6,69,199,161,112,119,251,243,209,215,58,216,5,230,178,22,54,179,159,184,219,250,17,47,249,212,43,218,156,248,227,22,207,28,185,156,184,88,114,81,180,165,168,191,4,54,196,45,219,89,75,110,64,192,9,120,50,182,181,133,0,72,126,193,22,22,180,161,105,179,242,141,108,1,176,68,25,137,122,145,245,49,34,114,86,37,40,2,154,181,166,199,143,97,109,171,57,54,167,126,66,219,230,152,77,120,188,132,96,81,9,112,61,171,134,179,1,83,19,198,163,86,145,85,143,99,131,111,75,179,1,35,134,60,144,211,134,61,116,153,51,205,63,25,241,81,43,228,94,136,41,247,185,97,214,184,126,7,155,71,46,27,0,19,198,91,100,143,51,144,253,220,32,231,89,72,45,136,90,182,244,40,219,254,127,239,189,247,64,92,68,206,236,51,231,97,162,6,224,240,82,5,77,148,209,40,18,10,165,66,231,143,30,220,240,147,116,211,156,23,192,161,249,149,229,202,93,206,156,30,177,26,195,184,62,147,170,215,33,85,174,25,125,106,132,170,164,25,124,38,71,175,69,142,108,131,247,244,136,81,41,107,245,56,164,40,71,124,78,170,244,212,210,228,22,115,180,134,81,149,49,167,137,245,99,114,140,83,177,161,106,69,179,23,223,21,169,108,83,114,86,62,215,162,38,0,75,102,194,206,77,108,170,242,45,207,208,110,59,142,76,244,13,17,200,83,127,191,150,90,10,238,43,48,121,99,197,134,15,160,34,225,81,114,241,166,62,54,228,182,76,157,219,219,103,18,204,131,163,156,234,108,52,212,115,128,60,102,225,91,140,132,112,117,83,95,120,82,205,202,82,84,166,109,191,225,131,120,19,45,100,61,192,223,20,192,127,3,215,181,136,42,4,215,34,247,166,29,30,219,95,106,4,248,218,0,93,163,86,194,218,219,107,45,37,125,33,122,182,68,3,87,183,197,13,95,232,37,144,10,135,5,117,60,12,41,24,49,18,189,195,210,235,172,126,13,49,152,181,154,14,190,188,82,179,254,53,144,152,23,7,101,30,79,48,164,113,237,187,203,188,144,15,209,13,134,212,80,96,68,224,1,8,134,252,89,120,97,232,244,178,75,168,236,61,207,246,8,109,2,15,142,97,229,94,142,238,179,136,26,19,21,105,161,164,227,64,109,34,219,54,118,61,167,45,47,69,200,161,105,144,47,68,209,4,59,30,100,207,24,245,76,34,183,178,61,211,152,177,66,15,39,32,89,98,195,235,244,11,150,189,206,59,81,114,229,93,184,189,6,161,178,90,178,72,244,150,171,27,112,91,200,6,19,102,43,121,17,81,163,76,3,164,207,81,201,112,218,160,158,245,106,240,82,158,68,215,139,109,27,40,53,96,160,184,195,7,213,140,97,166,14,120,119,220,100,23,223,22,251,113,58,182,11,204,80,212,184,186,160,99,189,42,133,33,250,103,177,82,142,240,220,2,13,98,153,30,85,13,162,113,45,33,108,2,249,45,112,171,58,59,87,139,164,179,136,56,203,191,46,90,217,191,219,30,176,251,6,252,180,233,1,176,220,234,39,100,246,146,120,41,143,240,15,44,129,190,72,144,115,0,216,197,75,224,229,109,248,242,78,101,52,130,46,140,100,37,89,109,13,59,131,49,97,33,30,109,150,158,106,206,134,88,137,33,22,54,111,84,39,5,140,212,66,200,174,111,68,88,239,229,12,88,64,217,232,1,242,88,120,163,159,179,191,100,252,224,196,232,129,92,142,201,131,20,60,230,217,178,223,9,175,184,99,211,169,33,220,48,149,157,37,131,172,10,73,104,45,137,27,44,84,152,235,95,84,101,150,41,80,200,78,213,37,253,1,220,161,118,66,100,54,14,197,120,58,165,63,28,253,126,244,31,236,100,10,211,76,217,143,180,170,128,183,157,189,32,151,64,21,182,48,5,181,88,224,186,91,195,105,123,85,148,177,80,104,146,208,23,212,224,120,74,169,98,218,242,89,3,101,61,229,144,88,214,158,149,69,129,222,227,98,246,210,201,162,248,185,74,224,106,120,139,25,88,244,157,165,232,216,117,118,157,76,19,227,101,65,60,40,97,14,148,68,205,96,37,81,2,40,137,91,197,230,27,148,0,97,6,27,201,91,18,202,132,221,61,25,238,203,161,106,35,42,203,81,209,148,75,132,17,21,7,129,133,209,228,229,20,245,163,230,131,116,201,88,247,28,121,59,52,88,214,211,165,161,178,190,78,13,183,33,167,43,121,77,165,213,74,12,60,114,53,97,55,242,244,113,255,43,76,143,144,60,127,198,174,244,161,127,165,6,243,136,252,28,217,36,155,62,64,223,35,113,247,2,194,220,10,1,122,140,70,131,15,144,197,202,16,160,71,193,193,226,39,51,200,115,129,64,240,221,154,93,20,206,222,157,36,77,219,43,73,69,69,108,45,64,68,106,147,247,223,243,209,125,62,209,177,37,222,255,100,7,52,139,29,164,100,77,173,187,102,139,163,196,127,96,113,10,149,21,121,158,142,46,13,49,86,44,120,5,89,128,181,40,202,98,186,11,37,204,149,26,167,118,149,201,119,135,167,173,46,235,45,215,174,110,166,97,221,141,155,192,20,144,81,55,48,215,112,157,45,18,133,14,197,101,74,206,201,113,196,31,247,216,189,106,68,60,191,204,182,193,243,1,120,222,139,234,135,67,181,195,44,55,14,144,61,237,234,39,147,70,199,206,33,145,136,83,189,12,32,127,154,0,192,175,184,146,124,192,20,72,36,34,99,119,197,104,103,224,3,192,203,15,38,202,22,126,174,150,133,65,29,26,20,243,47,48,93,52,25,96,159,211,66,47,38,2,138,245,236,36,193,237,208,66,79,16,215,228,149,127,72,219,2,75,30,185,231,253,151,22,130,50,7,217,62,27,129,168,146,26,133,86,41,48,18,89,238,143,92,42,158,140,30,100,207,112,73,18,67,178,191,97,137,92,58,115,139,253,137,123,145,190,226,135,20,157,130,114,232,100,59,226,4,187,197,216,252,170,98,144,140,87,245,115,217,242,253,10,149,148,136,131,139,30,43,96,212,66,61,94,117,41,119,99,85,134,130,59,30,0,41,170,76,149,114,43,129,106,12,40,175,246,194,13,213,15,47,222,60,219,129,177,187,121,231,56,175,172,237,165,242,107,189,176,92,95,42,106,179,158,88,143,180,205,230,94,59,189,177,21,90,155,135,64,75,72,97,91,41,60,106,195,76,8,94,141,106,53,239,7,58,146,191,85,195,209,186,45,149,3,146,244,129,123,79,233,176,109,168,68,57,137,179,201,27,140,234,134,169,35,140,83,95,166,212,5,129,76,51,249,5,64,139,75,33,2,181,229,200,13,101,243,129,21,2,172,71,94,152,40,57,9,88,5,68,247,133,204,187,227,149,66,212,205,55,252,224,111,134,37,48,79,215,20,14,196,188,218,218,2,103,172,252,149,207,43,108,165,180,139,230,64,125,157,129,52,201,115,203,50,19,61,183,0,222,243,8,218,236,69,48,78,66,39,151,96,135,57,80,97,121,241,209,190,1,186,148,85,7,31,233,8,104,115,16,158,62,203,88,103,179,131,41,14,205,75,31,113,77,238,4,224,96,249,201,169,71,121,221,38,148,209,128,233,165,163,45,10,238,138,54,5,61,234,207,94,236,68,114,46,53,151,65,63,145,170,102,15,92,26,125,143,19,183,197,214,23,50,13,216,242,56,71,89,40,35,124,241,180,54,61,172,116,105,18,224,84,104,44,88,57,192,96,149,57,37,140,86,16,19,101,57,166,77,228,207,159,213,205,215,72,79,120,242,169,126,40,116,213,59,42,67,13,66,107,215,198,246,134,192,11,186,183,163,160,119,5,109,202,228,193,216,43,130,33,253,52,57,48,92,8,206,112,118,18,44,104,118,126,19,59,172,52,130,124,241,215,93,225,239,160,106,221,226,211,142,140,231,242,242,42,118,47,154,116,252,56,186,209,160,140,75,84,118,53,125,168,164,212,243,57,173,152,114,60,201,37,197,170,16,247,120,146,86,76,210,121,118,11,241,152,50,88,14,250,65,246,228,72,36,244,145,215,241,26,216,231,10,239,92,242,51,44,114,231,145,136,205,196,166,184,167,5,199,51,90,59,145,53,125,2,71,131,71,251,138,182,238,47,148,124,54,45,0,45,40,39,134,18,213,172,101,185,79,31,162,149,182,25,143,116,201,246,130,71,171,60,167,127,15,178,151,81,137,98,219,20,245,78,176,160,52,176,75,64,220,151,11,250,10,197,217,142,198,86,169,226,124,102,218,23,115,100,217,226,175,74,22,102,38,164,167,40,47,60,141,46,176,12,236,131,215,236,125,114,116,49,137,111,158,132,74,86,71,211,148,219,145,7,33,95,206,213,5,90,136,65,139,42,95,216,104,147,74,188,244,163,23,20,1,128,88,1,135,26,113,1,248,207,159,134,111,49,144,17,95,38,0,73,12,19,174,87,140,129,186,166,179,177,77,10,210,201,229,86,103,89,131,137,129,93,40,30,164,142,210,53,10,253,224,178,101,16,133,10,125,193,37,44,196,162,113,166,182,58,241,243,143,189,187,177,140,141,7,58,164,249,247,73,247,214,224,54,11,140,87,54,185,58,48,196,46,201,149,73,119,111,183,105,10,99,3,139,134,103,76,160,143,250,106,95,246,85,132,139,208,75,98,104,101,197,89,78,81,104,193,55,116,124,189,202,88,152,59,11,108,0,55,80,138,235,208,246,179,144,233,167,231,145,60,171,195,90,235,148,28,22,90,152,208,104,128,225,143,8,42,12,110,196,146,136,110,43,193,77,145,203,143,42,215,55,11,147,201,33,201,50,85,237,67,201,161,64,118,62,63,243,47,174,244,151,208,174,145,158,149,236,154,66,112,151,122,189,14,105,119,251,73,58,184,198,191,166,182,64,86,91,116,105,53,167,213,156,197,93,223,41,3,247,220,46,101,68,195,41,237,132,164,54,128,90,104,26,116,136,77,138,17,124,237,171,174,245,151,223,97,129,81,157,34,173,121,165,255,17,93,77,253,67,250,193,218,250,96,35,238,215,189,135,56,88,121,206,48,64,56,54,13,205,130,210,92,243,139,215,156,118,125,202,184,65,58,76,176,97,104,193,234,35,31,100,104,139,206,124,174,0,71,209,56,159,71,11,46,83,115,135,232,143,210,164,248,133,46,139,239,83,19,131,109,2,112,59,99,75,108,69,88,14,6,126,249,224,1,243,0,176,253,12,190,123,193,246,48,246,232,112,22,237,29,227,74,198,210,99,164,202,181,159,213,111,10,176,163,148,172,112,36,231,38,138,35,184,156,242,88,232,30,239,170,202,224,253,148,46,163,142,254,234,211,201,74,208,184,151,28,157,114,1,26,255,110,167,51,249,153,196,53,58,167,91,124,198,191,60,232,76,122,38,112,205,205,41,23,158,113,239,246,57,137,178,67,105,73,210,46,157,138,49,201,6,173,187,67,83,137,12,55,71,132,78,239,73,63,35,15,141,139,245,23,53,243,204,69,103,109,85,112,51,52,150,118,71,242,189,151,64,219,155,250,210,55,236,80,124,174,204,85,197,248,88,129,247,126,160,124,49,244,196,22,96,190,57,43,170,57,232,210,254,215,236,155,236,113,246,29,219,134,244,17,80,24,19,80,128,75,173,38,248,119,14,217,152,104,115,247,0,253,153,103,29,40,22,245,115,228,252,249,118,29,108,118,221,104,223,164,197,150,111,183,82,218,197,255,68,215,22,233,149,238,157,86,218,110,117,7,49,207,13,239,102,41,170,248,208,63,98,170,124,120,101,196,5,243,29,31,53,79,41,39,102,114,249,52,227,219,146,198,218,203,132,81,121,6,172,144,12,225,188,149,114,34,71,90,5,32,162,35,20,16,254,86,29,8,228,170,2,5,210,224,215,180,11,135,58,113,30,193,64,196,126,242,26,112,169,195,59,6,154,22,92,191,46,1,9,10,138,246,208,52,194,234,197,246,79,186,238,30,252,229,32,107,234,22,95,160,170,97,240,0,156,228,186,138,141,201,244,189,251,94,117,229,215,57,176,90,153,147,68,108,123,21,124,49,170,212,108,232,253,96,138,216,165,177,192,177,173,44,43,9,158,164,176,191,233,130,19,176,59,176,236,6,135,31,97,149,250,118,35,10,39,138,128,251,61,40,91,185,59,58,178,31,75,180,51,247,99,95,208,9,141,55,210,108,246,160,13,173,60,58,11,201,172,188,123,85,158,214,156,47,85,133,41,197,29,73,202,168,90,244,137,141,159,70,247,105,237,231,38,82,21,142,45,6,133,39,22,180,221,137,115,183,182,20,89,252,243,61,129,136,133,98,129,183,135,240,141,130,123,38,55,139,198,196,138,182,218,89,116,248,126,102,190,189,38,226,197,97,202,30,74,217,101,193,169,202,60,41,197,60,246,165,183,231,220,231,14,2,238,143,136,129,242,156,56,71,198,162,94,254,47,251,207,200,74,102,77,242,103,176,131,190,50,235,80,252,117,122,245,75,206,240,173,8,60,11,62,235,55,182,103,93,141,171,223,113,95,232,193,81,243,115,87,160,137,66,207,39,159,81,127,230,13,248,133,31,202,59,210,177,187,165,16,69,121,111,147,101,216,22,205,123,32,14,152,120,159,171,177,74,99,202,30,29,49,179,34,245,255,137,178,195,64,29,147,236,239,39,76,182,173,105,39,67,118,24,106,189,140,145,114,120,71,82,238,78,128,243,77,65,125,206,92,101,56,103,174,193,23,97,205,137,186,215,227,19,203,243,73,31,39,37,147,233,130,49,191,7,86,154,190,201,122,52,39,210,87,199,74,114,209,242,182,225,172,20,44,193,197,230,178,78,201,115,113,201,69,98,145,225,92,46,22,178,244,226,178,72,107,9,159,161,63,202,219,36,224,19,234,202,165,34,97,227,187,2,238,193,176,67,95,150,186,200,28,174,66,109,124,236,52,191,149,4,87,161,86,3,216,58,212,74,154,115,96,155,178,56,193,45,169,130,26,23,172,22,123,87,183,133,172,195,139,217,0,11,189,133,60,237,12,20,49,13,228,46,91,125,200,189,72,214,208,17,119,9,178,176,150,115,127,77,120,57,103,83,137,22,116,229,241,89,145,172,1,108,22,187,14,133,75,199,181,230,227,82,124,71,184,28,137,40,141,21,196,184,230,227,53,194,21,142,190,230,105,132,254,211,177,28,22,146,178,14,62,163,243,221,32,39,168,0,177,86,140,156,164,72,62,106,172,254,207,69,87,189,176,208,23,97,228,122,30,213,139,188,113,52,232,42,204,255,138,227,88,95,150,124,221,95,163,12,236,168,216,34,86,97,158,209,91,86,238,189,57,89,232,198,133,50,55,108,72,99,254,137,184,201,83,72,171,71,98,69,148,159,218,19,192,55,111,92,242,136,181,218,19,208,205,118,175,53,152,84,179,177,113,98,50,236,32,116,101,118,200,145,170,104,193,151,127,156,88,90,240,145,143,0,45,248,254,145,19,75,11,106,102,136,150,240,21,40,39,150,174,96,147,157,216,191,208,82,219,57,120,129,71,154,218,41,66,169,5,155,79,14,72,44,240,10,36,74,173,10,18,203,157,2,137,82,171,130,12,119,191,102,66,168,68,108,105,50,20,87,105,235,183,138,6,218,196,12,11,199,174,16,102,68,101,91,201,107,7,34,224,252,250,206,241,128,123,140,190,201,130,70,54,94,30,104,95,103,186,230,85,169,187,220,104,69,173,37,248,195,42,11,6,46,119,13,220,103,128,72,223,253,83,210,22,204,185,88,202,42,225,185,49,202,42,81,112,21,148,197,35,87,216,61,41,158,107,5,253,166,71,145,113,90,243,46,198,99,109,44,18,243,151,159,3,134,151,67,186,27,214,150,175,3,161,1,152,13,70,162,209,160,45,53,85,224,2,6,236,224,7,168,148,245,151,227,58,128,162,50,142,111,0,57,116,136,211,132,64,162,115,33,103,13,25,251,252,85,156,183,190,4,75,26,206,0,184,240,13,62,23,28,149,203,57,34,57,167,46,23,43,73,233,225,8,149,148,242,166,155,63,54,237,144,116,93,29,188,85,166,220,115,134,115,34,116,87,237,97,52,154,196,15,63,123,95,243,244,60,238,120,235,125,76,14,160,115,166,133,28,64,46,57,212,150,0,50,215,4,240,30,58,205,209,119,155,255,15,38,162,29,28,229,160,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09a87c67-bcd5-4ac6-b1fe-80bc8a216ea8"));
		}

		#endregion

	}

	#endregion

}

