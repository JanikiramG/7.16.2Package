namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContractInFolder

	/// <exclude/>
	public class ContractInFolder : Terrasoft.Configuration.ContractInFolder
	{

		#region Constructors: Public

		public ContractInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContractInFolder(Terrasoft.Configuration.ContractInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

