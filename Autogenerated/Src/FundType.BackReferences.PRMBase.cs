namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FundType

	/// <exclude/>
	public class FundType : Terrasoft.Configuration.FundType
	{

		#region Constructors: Public

		public FundType(UserConnection userConnection)
			: base(userConnection) {
		}

		public FundType(Terrasoft.Configuration.FundType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Fund> FundCollectionByFundType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

