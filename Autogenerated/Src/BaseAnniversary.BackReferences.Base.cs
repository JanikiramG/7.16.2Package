namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseAnniversary

	/// <exclude/>
	public class BaseAnniversary : Terrasoft.Configuration.BaseAnniversary
	{

		#region Constructors: Public

		public BaseAnniversary(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseAnniversary(Terrasoft.Configuration.BaseAnniversary source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

