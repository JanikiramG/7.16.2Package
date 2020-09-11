namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FileImportParameters

	/// <exclude/>
	public class FileImportParameters : Terrasoft.Configuration.FileImportParameters
	{

		#region Constructors: Public

		public FileImportParameters(UserConnection userConnection)
			: base(userConnection) {
		}

		public FileImportParameters(Terrasoft.Configuration.FileImportParameters source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ImportSessionChunk> ImportSessionChunkCollectionByImportParameters {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

