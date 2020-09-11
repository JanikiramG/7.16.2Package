namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContractFolder

	/// <exclude/>
	public class ContractFolder : Terrasoft.Configuration.ContractFolder
	{

		#region Constructors: Public

		public ContractFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContractFolder(Terrasoft.Configuration.ContractFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ContractFolder> ContractFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<ContractInFolder> ContractInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

