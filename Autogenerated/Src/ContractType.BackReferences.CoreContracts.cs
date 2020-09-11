namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContractType

	/// <exclude/>
	public class ContractType : Terrasoft.Configuration.ContractType
	{

		#region Constructors: Public

		public ContractType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContractType(Terrasoft.Configuration.ContractType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Contract> ContractCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

