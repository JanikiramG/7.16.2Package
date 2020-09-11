namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContractFile

	/// <exclude/>
	public class ContractFile : Terrasoft.Configuration.ContractFile
	{

		#region Constructors: Public

		public ContractFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContractFile(Terrasoft.Configuration.ContractFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

