namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContractState

	/// <exclude/>
	public class ContractState : Terrasoft.Configuration.ContractState
	{

		#region Constructors: Public

		public ContractState(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContractState(Terrasoft.Configuration.ContractState source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Contract> ContractCollectionByState {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

