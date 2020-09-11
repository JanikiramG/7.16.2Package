namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContractVisa

	/// <exclude/>
	public class ContractVisa : Terrasoft.Configuration.ContractVisa
	{

		#region Constructors: Public

		public ContractVisa(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContractVisa(Terrasoft.Configuration.ContractVisa source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

