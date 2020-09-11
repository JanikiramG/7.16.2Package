﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLServiceProxySchema

	/// <exclude/>
	public class MLServiceProxySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLServiceProxySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLServiceProxySchema(MLServiceProxySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9ede723f-6621-4b3c-ae0f-44ad2d0ebf8f");
			Name = "MLServiceProxy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,28,93,115,219,54,242,217,157,185,255,128,83,59,19,170,213,80,206,245,174,55,227,15,117,18,39,78,117,181,146,140,37,95,30,58,157,14,37,66,50,47,20,169,146,160,29,213,245,127,191,221,5,64,130,36,72,42,118,156,75,123,121,104,19,129,139,197,126,239,98,1,36,242,214,60,221,120,11,206,102,60,73,188,52,94,10,247,36,142,150,193,42,75,60,17,196,145,59,57,251,203,23,55,127,249,98,47,75,131,104,197,166,219,84,240,245,97,229,55,76,9,67,190,64,248,212,125,193,35,158,4,139,26,204,89,16,253,90,27,124,201,69,49,182,10,227,185,23,30,28,156,196,235,53,172,124,22,175,86,48,92,124,63,231,169,152,94,122,201,166,24,50,169,198,73,246,47,9,119,79,189,133,136,147,128,167,54,136,201,153,59,142,4,79,150,32,136,110,0,247,156,255,154,1,41,59,65,166,27,144,137,29,233,27,62,119,127,16,98,227,62,153,167,34,241,164,248,0,16,64,191,76,248,10,126,177,28,213,1,27,79,206,166,60,185,10,22,252,117,18,191,219,18,216,112,56,100,71,105,182,94,123,201,118,164,126,231,83,216,50,78,216,194,11,67,92,117,237,45,46,131,136,179,144,123,73,132,3,169,196,229,106,44,67,3,205,38,155,135,193,130,109,188,68,4,94,200,130,28,99,141,134,189,27,162,35,167,119,194,197,101,236,167,7,236,53,161,144,31,171,84,210,192,84,0,246,148,69,252,154,1,239,65,4,4,165,41,218,91,62,99,88,157,114,4,4,121,107,22,129,201,30,247,214,92,120,207,60,225,245,70,176,166,199,124,248,43,139,151,76,92,114,182,142,125,30,62,74,129,238,77,38,152,23,249,44,206,4,252,213,61,26,18,134,6,132,56,107,186,184,228,107,111,236,3,214,51,137,135,165,52,196,2,159,71,34,88,6,60,169,163,73,184,200,146,40,29,205,96,241,2,78,147,147,34,167,220,207,25,60,26,106,120,68,240,34,11,124,41,140,25,138,97,42,129,28,48,8,82,155,226,114,192,8,174,68,99,255,176,69,188,23,155,48,246,252,84,202,69,196,146,144,66,229,187,72,216,39,233,62,83,8,50,66,216,46,66,197,33,138,207,46,10,210,180,180,62,45,139,2,221,85,12,28,74,186,113,81,45,2,191,96,63,199,223,202,250,83,48,197,40,45,173,183,43,203,194,80,129,230,162,100,157,173,102,80,49,79,112,132,151,240,247,222,8,255,175,37,112,205,231,76,126,171,243,78,132,207,20,201,14,113,92,38,104,192,10,179,80,216,91,37,241,130,11,244,2,136,3,107,138,229,204,155,131,39,216,53,241,81,36,164,13,191,226,2,92,104,140,64,171,14,153,72,189,22,134,241,217,38,151,86,33,156,64,4,76,217,34,244,0,120,25,44,164,32,222,211,21,200,239,198,17,120,114,180,224,23,154,111,25,31,2,53,12,140,183,155,132,244,167,49,5,37,114,75,144,81,8,46,74,97,186,76,30,97,110,22,223,89,144,10,52,168,163,148,115,182,72,248,242,184,119,82,66,0,50,204,66,209,27,142,42,193,166,12,245,138,162,34,83,131,91,167,8,49,6,171,3,246,44,160,204,4,194,57,146,230,55,96,241,252,63,144,237,71,196,70,171,240,167,11,200,189,41,131,82,66,166,163,0,114,62,187,14,196,37,25,225,42,184,226,145,148,133,204,141,20,165,54,124,129,230,163,72,121,47,21,65,216,198,63,6,128,200,19,44,189,140,179,208,103,27,72,94,224,1,16,200,99,164,126,23,37,161,118,205,140,66,100,155,56,231,156,208,241,14,149,111,0,2,164,7,5,21,8,110,158,81,130,239,229,160,227,200,71,77,240,116,192,130,165,54,73,189,130,84,27,88,151,31,92,5,126,6,105,120,201,61,24,2,133,155,216,48,52,199,87,60,1,35,103,106,181,178,55,55,152,208,107,9,139,105,9,249,32,13,85,140,101,42,229,165,172,132,52,233,76,206,72,192,178,66,148,10,234,52,144,1,155,199,113,78,93,73,22,187,218,142,116,146,80,153,61,106,35,253,228,173,8,157,84,90,146,166,91,91,148,164,255,79,111,78,105,197,158,80,32,71,37,163,26,181,89,213,152,224,155,109,75,26,23,2,13,16,251,222,221,140,236,181,84,43,152,25,95,37,42,131,129,138,162,108,141,123,24,118,229,133,25,255,168,198,215,157,101,118,43,64,118,49,65,228,171,224,187,57,223,20,218,45,201,197,166,95,63,134,194,159,143,96,171,70,104,155,114,202,238,202,221,85,123,11,216,254,241,200,151,249,19,25,43,148,144,129,47,164,119,137,0,185,212,219,69,77,248,123,163,11,252,3,29,104,197,69,133,160,246,249,8,155,248,233,73,156,69,160,174,151,217,122,46,43,102,21,39,226,2,25,49,198,97,43,71,60,181,99,93,6,33,108,219,198,136,3,170,14,141,74,142,238,60,19,197,32,133,129,4,201,15,131,29,38,63,9,19,238,249,91,218,139,122,104,57,138,142,83,250,138,251,49,230,73,16,185,187,36,24,109,149,73,188,54,131,79,167,236,21,238,139,13,8,91,171,91,226,234,148,187,23,46,178,16,102,93,72,21,158,23,35,10,77,89,143,169,114,114,163,240,42,8,24,142,204,213,206,75,19,243,162,54,31,182,7,61,114,11,244,153,145,92,127,128,226,97,166,129,200,96,103,192,25,218,98,199,224,160,97,40,65,202,4,156,150,117,202,42,58,134,153,173,240,238,155,75,16,168,17,104,219,212,12,200,68,146,113,197,13,238,229,82,46,254,141,17,67,114,85,167,149,80,86,213,1,16,75,47,76,243,45,206,151,64,155,108,51,208,239,91,217,40,41,15,234,62,4,213,180,7,108,199,150,201,83,32,144,5,235,77,200,129,127,33,67,72,185,188,174,52,62,176,178,182,53,78,36,114,206,129,236,184,97,38,27,34,224,79,207,248,210,131,18,253,41,38,100,216,236,137,237,134,199,75,167,2,220,239,255,92,239,198,208,86,161,194,25,179,180,135,170,173,25,48,52,12,102,2,155,51,73,112,5,82,150,223,55,242,7,214,1,144,35,212,6,243,13,159,63,127,183,224,27,20,197,4,226,184,183,2,19,33,85,245,32,157,36,252,17,118,110,196,117,156,188,101,16,145,68,176,230,232,210,92,79,97,151,94,228,135,224,139,126,70,232,176,11,197,30,221,236,223,62,114,177,215,33,50,32,226,230,241,237,128,41,220,240,235,111,183,189,195,70,114,78,194,56,243,21,123,233,147,77,240,35,223,130,117,244,202,195,175,199,48,220,179,27,75,46,133,83,218,115,161,8,98,193,209,98,91,178,11,37,206,120,181,130,120,105,79,30,27,141,4,123,60,2,116,132,222,16,71,225,22,242,91,188,98,248,223,49,254,127,226,69,30,98,129,29,237,25,225,115,122,147,179,94,107,102,155,169,94,129,46,227,22,97,0,166,217,73,199,24,91,164,39,4,203,126,185,20,98,35,255,222,181,18,200,142,189,229,219,78,244,57,127,74,47,191,120,164,139,14,153,147,229,37,25,246,95,119,233,12,142,163,0,13,61,248,13,202,126,143,26,132,121,241,163,182,99,134,99,214,189,75,58,200,174,233,94,201,247,34,9,101,161,164,229,125,113,126,214,158,60,36,231,114,146,22,95,109,66,225,16,42,24,68,16,200,33,206,137,82,139,61,247,52,76,64,191,102,65,130,6,69,237,113,32,71,8,16,52,8,2,138,234,40,22,56,0,203,228,120,165,126,100,128,40,139,66,183,207,10,6,243,238,145,36,189,207,110,200,161,79,46,249,226,173,94,119,42,215,115,44,14,55,208,243,200,77,247,148,234,193,192,115,27,128,81,212,221,15,185,217,57,197,226,114,214,237,67,171,157,10,36,132,93,100,169,136,243,221,26,54,129,245,58,149,86,11,216,236,38,134,36,251,137,88,140,57,65,81,186,157,24,189,196,19,59,245,29,125,89,220,101,153,88,212,46,172,101,250,199,177,220,159,94,205,211,56,228,130,59,189,127,186,143,191,115,247,217,239,102,180,96,65,202,124,190,193,194,0,162,143,203,222,4,144,70,96,175,156,240,53,108,82,161,94,132,74,63,163,77,108,194,67,14,73,60,237,81,198,188,163,71,228,63,235,130,207,63,85,68,217,39,171,223,59,0,155,11,82,199,196,92,113,178,26,70,112,156,250,50,210,137,166,229,53,0,178,178,170,233,75,77,65,23,88,222,112,168,24,248,123,36,59,95,22,37,32,77,58,223,202,243,58,48,182,232,119,38,135,171,32,17,153,60,46,98,170,188,153,73,4,83,190,96,55,184,45,58,100,183,192,205,183,251,221,39,23,114,167,122,127,66,138,243,4,59,45,223,181,210,82,241,182,251,147,163,237,192,78,204,63,186,218,97,104,129,247,39,130,236,235,14,20,60,245,4,236,60,211,15,70,7,225,107,33,230,219,253,86,229,156,23,29,155,251,211,82,32,187,179,96,146,15,73,15,161,236,34,234,227,10,200,220,30,222,137,30,58,229,204,207,137,52,73,58,127,230,185,104,87,170,84,68,38,172,234,40,200,8,154,6,89,189,161,90,115,72,71,177,189,247,141,62,247,165,176,136,65,77,244,225,114,67,121,194,218,74,29,108,32,138,115,182,104,25,127,48,18,203,71,112,93,98,196,165,135,48,222,74,107,67,236,188,47,165,150,76,106,210,168,171,59,158,12,85,11,169,149,200,106,80,189,183,49,86,82,183,73,26,37,241,221,200,178,120,238,125,41,83,40,27,104,83,177,43,174,145,215,84,94,72,60,13,173,4,181,27,166,67,109,235,246,34,175,196,232,103,185,192,146,99,212,46,210,213,83,176,196,128,85,140,187,227,244,101,22,134,175,146,231,235,141,216,58,125,13,183,39,46,147,248,154,246,14,29,245,170,99,44,173,54,52,183,70,81,165,25,153,189,130,88,169,186,223,71,179,113,52,160,145,209,253,187,218,178,237,181,87,59,206,151,253,62,145,71,215,182,179,51,137,226,26,219,49,12,104,99,7,154,82,234,55,146,213,232,230,27,29,58,143,6,40,25,167,60,15,216,57,144,195,74,134,85,174,92,82,224,147,100,149,97,111,76,10,28,119,21,241,210,169,130,246,149,36,53,147,229,169,166,198,20,130,188,199,175,38,94,121,9,73,8,40,198,246,32,168,177,222,65,116,20,44,108,244,168,17,238,116,156,62,226,38,33,95,71,219,9,46,36,111,7,201,101,204,21,244,2,196,134,251,6,197,228,192,86,141,190,177,227,17,211,127,119,229,200,95,101,31,179,239,158,198,201,115,32,200,132,149,120,246,104,37,247,137,239,231,223,92,218,109,148,49,245,205,117,113,179,132,19,104,170,105,160,68,186,142,9,146,120,212,189,226,139,58,202,99,31,62,212,140,83,2,20,22,242,26,247,123,105,153,127,121,55,65,225,218,163,155,63,199,90,33,10,129,198,80,50,69,128,178,89,168,156,33,201,190,149,60,144,67,37,186,25,126,204,94,199,160,95,233,83,166,19,40,6,7,134,39,40,33,168,115,76,141,226,208,226,180,20,118,102,137,23,165,120,54,164,59,239,207,147,36,78,158,110,101,247,209,161,62,89,222,148,215,216,180,125,168,175,82,200,133,176,53,152,190,255,39,41,170,249,48,65,18,0,94,255,139,179,100,161,246,117,121,244,97,252,157,137,142,72,43,62,126,255,61,233,164,136,85,101,64,213,50,85,242,72,175,3,172,61,11,24,201,224,9,168,63,183,246,5,182,183,177,43,83,124,115,47,34,47,3,130,147,224,55,238,31,40,213,238,30,61,173,237,161,95,74,253,33,235,170,224,35,243,192,247,121,164,151,68,107,230,200,213,51,46,188,32,68,75,250,170,151,235,133,78,130,10,193,30,176,155,226,199,173,60,131,253,233,166,105,137,219,159,123,236,27,181,204,222,87,189,155,92,66,104,163,16,143,84,191,185,196,55,226,178,200,189,64,63,40,81,219,198,234,203,88,156,198,89,116,7,225,246,148,96,21,231,189,129,153,31,52,67,21,32,234,176,44,113,189,94,27,81,116,80,19,121,33,78,230,9,153,147,166,47,55,99,213,236,7,61,212,100,107,153,126,251,51,107,145,236,89,188,146,70,235,40,188,32,191,119,253,59,201,221,130,192,198,225,83,207,87,222,105,154,152,242,199,167,177,191,53,188,147,66,32,23,120,56,124,26,36,169,120,149,168,182,133,179,193,64,191,113,103,219,13,72,2,162,148,6,196,1,237,253,136,172,47,67,247,97,89,134,220,112,83,187,32,11,42,65,126,166,129,247,180,126,191,129,105,37,107,191,49,120,176,9,152,215,99,195,93,44,123,82,23,179,234,10,149,13,153,191,107,174,154,138,186,79,25,169,118,232,142,176,91,139,101,26,82,82,89,142,103,229,111,224,110,17,63,104,254,124,18,227,233,158,200,99,157,13,166,228,14,88,114,66,246,21,125,139,168,216,232,152,253,125,127,159,253,254,59,107,4,1,171,217,207,9,134,188,215,158,142,114,73,104,197,221,170,63,231,80,228,188,61,108,166,25,247,225,62,214,112,205,32,79,230,113,82,48,78,238,80,201,85,229,172,86,73,90,134,141,157,210,61,82,199,114,54,88,10,81,172,45,95,149,89,178,154,22,154,171,46,26,129,181,87,203,115,47,90,241,194,120,45,245,186,253,114,8,212,22,149,11,208,197,189,28,121,5,215,190,135,162,17,60,145,53,123,232,51,108,113,43,195,149,215,201,25,130,184,71,195,28,242,253,110,2,167,165,0,222,117,83,33,247,125,121,126,160,139,146,57,140,180,79,45,42,40,117,89,87,117,128,82,190,104,190,240,163,57,125,148,22,87,231,205,171,62,198,46,19,125,29,37,237,88,246,50,178,14,55,163,111,117,127,211,81,113,25,71,152,238,9,216,141,224,255,74,243,205,141,173,98,164,160,172,14,168,140,185,170,93,133,23,19,138,198,213,215,236,241,62,53,172,242,36,97,196,166,242,218,196,160,90,66,161,183,198,55,19,69,233,196,171,125,27,189,99,139,222,60,33,11,84,42,102,72,101,251,233,112,235,9,150,105,2,245,222,1,105,183,122,166,87,61,69,105,61,72,236,77,206,128,181,121,200,215,148,59,167,197,210,3,86,61,29,164,160,75,253,29,249,88,103,235,206,146,237,11,46,156,226,184,79,210,0,115,81,155,134,134,100,11,224,75,64,240,242,249,236,244,252,201,228,249,155,87,231,63,202,176,98,42,18,111,122,192,122,120,164,146,47,14,107,127,201,195,148,183,65,99,76,186,72,130,202,129,38,106,53,88,202,104,196,16,133,14,248,6,18,186,89,163,207,228,53,95,210,150,139,241,218,65,169,74,0,38,49,176,29,84,229,201,15,220,243,241,14,129,44,188,123,149,202,251,115,72,252,31,135,196,153,218,213,142,238,26,18,85,107,166,220,151,249,104,17,146,74,26,252,57,221,120,145,123,10,91,48,32,42,142,252,212,49,104,116,103,177,240,194,73,16,134,65,42,191,238,28,71,81,48,119,10,165,123,51,179,115,96,126,119,177,85,209,217,31,232,142,193,255,143,111,214,244,192,110,111,215,10,70,75,182,47,143,219,239,241,148,77,25,121,189,185,101,158,238,104,235,55,155,93,18,3,138,211,151,237,170,124,153,26,80,209,23,211,191,205,206,84,121,161,202,14,69,119,170,108,64,35,199,126,2,85,116,177,36,37,181,35,113,123,71,203,205,95,53,117,70,243,79,243,141,159,68,194,134,237,143,253,148,201,188,207,155,63,165,119,106,203,214,58,203,142,100,69,119,197,244,36,91,247,218,96,161,127,216,96,118,5,73,21,163,51,154,162,74,175,185,190,168,168,80,127,55,45,139,138,71,219,25,160,209,231,180,93,83,232,78,231,127,196,151,142,166,226,239,244,224,81,105,162,12,104,213,115,133,199,70,101,19,25,39,249,193,161,38,168,162,121,83,207,101,204,53,101,91,91,217,13,254,223,166,223,79,246,253,166,66,64,7,125,220,101,227,101,49,59,101,11,221,107,25,168,87,71,93,60,84,43,41,149,77,238,253,42,244,195,91,74,149,166,59,24,72,3,91,69,166,145,200,40,221,216,97,71,78,211,105,125,183,181,181,213,71,246,83,252,63,223,235,89,61,176,235,43,90,38,47,251,55,215,61,15,242,170,182,124,113,176,160,168,94,152,168,227,233,42,164,50,4,59,130,81,237,240,86,101,179,226,208,181,229,20,251,70,106,224,118,96,185,141,49,176,220,113,27,20,15,57,44,5,143,20,88,173,7,223,29,30,63,63,46,254,3,189,6,181,7,249,143,241,198,88,121,146,90,170,205,133,114,16,229,59,149,41,202,105,220,201,7,113,29,137,171,56,144,127,174,46,246,232,178,178,124,47,114,208,248,180,245,129,60,234,243,147,235,63,160,147,85,159,92,43,47,123,224,151,215,45,79,175,245,5,174,72,0,211,25,117,67,39,158,184,116,39,65,228,60,30,228,120,92,122,218,168,187,192,69,59,44,7,247,222,57,213,139,194,95,75,140,3,235,53,226,254,225,199,241,249,92,16,205,238,172,121,185,139,7,119,55,116,63,63,95,239,126,190,158,11,171,225,25,123,107,113,247,64,175,218,13,199,176,216,186,245,226,247,215,21,119,25,52,95,18,87,86,85,162,221,98,251,197,212,220,252,205,41,150,34,177,234,249,181,91,165,134,185,183,212,124,239,99,215,159,31,246,127,126,216,255,41,61,236,87,113,225,161,222,247,131,123,62,222,87,222,181,195,43,255,135,123,230,255,16,239,252,59,30,250,171,160,88,21,109,245,204,11,11,109,59,140,253,26,108,83,242,110,184,12,91,70,93,190,19,139,244,142,125,132,148,177,103,202,241,159,189,116,232,98,48,119,103,241,148,2,190,211,199,3,50,148,138,211,175,220,155,37,98,75,218,174,255,227,14,123,123,167,37,109,27,74,252,126,135,21,245,5,82,210,138,204,64,163,130,142,170,133,28,87,109,196,192,137,40,227,107,248,22,93,121,73,224,69,162,138,166,209,46,218,204,102,96,202,82,193,231,230,162,63,158,215,109,164,106,54,18,178,116,189,88,165,25,106,158,217,29,84,215,115,182,66,45,111,158,53,189,117,106,187,210,97,251,231,40,96,236,191,144,95,187,229,96,85,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9ede723f-6621-4b3c-ae0f-44ad2d0ebf8f"));
		}

		#endregion

	}

	#endregion

}

