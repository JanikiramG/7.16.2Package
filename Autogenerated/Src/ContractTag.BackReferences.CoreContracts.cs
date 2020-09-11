namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContractTag

	/// <exclude/>
	public class ContractTag : Terrasoft.Configuration.ContractTag
	{

		#region Constructors: Public

		public ContractTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContractTag(Terrasoft.Configuration.ContractTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ContractInTag> ContractInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

