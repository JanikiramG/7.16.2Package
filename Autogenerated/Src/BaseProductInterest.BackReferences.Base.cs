namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseProductInterest

	/// <exclude/>
	public class BaseProductInterest : Terrasoft.Configuration.BaseProductInterest
	{

		#region Constructors: Public

		public BaseProductInterest(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseProductInterest(Terrasoft.Configuration.BaseProductInterest source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

