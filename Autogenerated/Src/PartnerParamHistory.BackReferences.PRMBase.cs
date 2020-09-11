namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PartnerParamHistory

	/// <exclude/>
	public class PartnerParamHistory : Terrasoft.Configuration.PartnerParamHistory
	{

		#region Constructors: Public

		public PartnerParamHistory(UserConnection userConnection)
			: base(userConnection) {
		}

		public PartnerParamHistory(Terrasoft.Configuration.PartnerParamHistory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

