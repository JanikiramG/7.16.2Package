namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwAnniversary

	/// <exclude/>
	public class VwAnniversary : Terrasoft.Configuration.VwAnniversary
	{

		#region Constructors: Public

		public VwAnniversary(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwAnniversary(Terrasoft.Configuration.VwAnniversary source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

