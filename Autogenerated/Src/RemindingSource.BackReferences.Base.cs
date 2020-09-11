namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: RemindingSource

	/// <exclude/>
	public class RemindingSource : Terrasoft.Configuration.RemindingSource
	{

		#region Constructors: Public

		public RemindingSource(UserConnection userConnection)
			: base(userConnection) {
		}

		public RemindingSource(Terrasoft.Configuration.RemindingSource source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Reminding> RemindingCollectionBySource {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

