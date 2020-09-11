namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Lookup

	/// <exclude/>
	public class Lookup : Terrasoft.Configuration.Lookup
	{

		#region Constructors: Public

		public Lookup(UserConnection userConnection)
			: base(userConnection) {
		}

		public Lookup(Terrasoft.Configuration.Lookup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<LookupInFolder> LookupInFolderCollectionByLookup {
			get;
			set;
		}

		public IEnumerable<LookupInTag> LookupInTagCollectionByEntity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

