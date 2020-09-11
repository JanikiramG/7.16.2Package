﻿namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSocialUnsubscription

	/// <exclude/>
	public class VwSocialUnsubscription : Terrasoft.Configuration.VwSocialUnsubscription
	{

		#region Constructors: Public

		public VwSocialUnsubscription(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSocialUnsubscription(Terrasoft.Configuration.VwSocialUnsubscription source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}
