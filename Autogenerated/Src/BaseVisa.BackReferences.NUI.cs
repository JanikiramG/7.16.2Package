namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseVisa

	/// <exclude/>
	public class BaseVisa : Terrasoft.Configuration.BaseVisa
	{

		#region Constructors: Public

		public BaseVisa(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseVisa(Terrasoft.Configuration.BaseVisa source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

