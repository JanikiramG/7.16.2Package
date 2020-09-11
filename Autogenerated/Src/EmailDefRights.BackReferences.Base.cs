namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailDefRights

	/// <exclude/>
	public class EmailDefRights : Terrasoft.Configuration.EmailDefRights
	{

		#region Constructors: Public

		public EmailDefRights(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailDefRights(Terrasoft.Configuration.EmailDefRights source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

