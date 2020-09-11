namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LevelPartnershipParam

	/// <exclude/>
	public class LevelPartnershipParam : Terrasoft.Configuration.LevelPartnershipParam
	{

		#region Constructors: Public

		public LevelPartnershipParam(UserConnection userConnection)
			: base(userConnection) {
		}

		public LevelPartnershipParam(Terrasoft.Configuration.LevelPartnershipParam source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

