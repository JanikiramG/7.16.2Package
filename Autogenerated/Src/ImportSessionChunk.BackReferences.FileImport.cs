namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ImportSessionChunk

	/// <exclude/>
	public class ImportSessionChunk : Terrasoft.Configuration.ImportSessionChunk
	{

		#region Constructors: Public

		public ImportSessionChunk(UserConnection userConnection)
			: base(userConnection) {
		}

		public ImportSessionChunk(Terrasoft.Configuration.ImportSessionChunk source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ChunkProcessResult> ChunkProcessResultCollectionByImportSessionChunk {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

