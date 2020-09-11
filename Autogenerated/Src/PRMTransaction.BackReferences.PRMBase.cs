namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PRMTransaction

	/// <exclude/>
	public class PRMTransaction : Terrasoft.Configuration.PRMTransaction
	{

		#region Constructors: Public

		public PRMTransaction(UserConnection userConnection)
			: base(userConnection) {
		}

		public PRMTransaction(Terrasoft.Configuration.PRMTransaction source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

