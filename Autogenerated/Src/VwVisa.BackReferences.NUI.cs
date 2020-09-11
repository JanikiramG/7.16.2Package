namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwVisa

	/// <exclude/>
	public class VwVisa : Terrasoft.Configuration.VwVisa
	{

		#region Constructors: Public

		public VwVisa(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwVisa(Terrasoft.Configuration.VwVisa source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

