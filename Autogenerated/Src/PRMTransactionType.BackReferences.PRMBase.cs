namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PRMTransactionType

	/// <exclude/>
	public class PRMTransactionType : Terrasoft.Configuration.PRMTransactionType
	{

		#region Constructors: Public

		public PRMTransactionType(UserConnection userConnection)
			: base(userConnection) {
		}

		public PRMTransactionType(Terrasoft.Configuration.PRMTransactionType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<PRMTransaction> PRMTransactionCollectionByTransactionType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

