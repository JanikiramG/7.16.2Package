namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwClientAddress

	/// <exclude/>
	public class VwClientAddress : Terrasoft.Configuration.VwClientAddress
	{

		#region Constructors: Public

		public VwClientAddress(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwClientAddress(Terrasoft.Configuration.VwClientAddress source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

