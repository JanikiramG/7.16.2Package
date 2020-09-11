namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContractInTag

	/// <exclude/>
	public class ContractInTag : Terrasoft.Configuration.ContractInTag
	{

		#region Constructors: Public

		public ContractInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContractInTag(Terrasoft.Configuration.ContractInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

