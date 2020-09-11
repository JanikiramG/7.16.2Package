namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwOrderProductFilter

	/// <exclude/>
	public class VwOrderProductFilter : Terrasoft.Configuration.VwOrderProductFilter
	{

		#region Constructors: Public

		public VwOrderProductFilter(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwOrderProductFilter(Terrasoft.Configuration.VwOrderProductFilter source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

