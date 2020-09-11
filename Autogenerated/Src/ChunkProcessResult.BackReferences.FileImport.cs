namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ChunkProcessResult

	/// <exclude/>
	public class ChunkProcessResult : Terrasoft.Configuration.ChunkProcessResult
	{

		#region Constructors: Public

		public ChunkProcessResult(UserConnection userConnection)
			: base(userConnection) {
		}

		public ChunkProcessResult(Terrasoft.Configuration.ChunkProcessResult source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

