namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityFolder

	/// <exclude/>
	public class OpportunityFolder : Terrasoft.Configuration.OpportunityFolder
	{

		#region Constructors: Public

		public OpportunityFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityFolder(Terrasoft.Configuration.OpportunityFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OpportunityFolder> OpportunityFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<OpportunityInFolder> OpportunityInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

