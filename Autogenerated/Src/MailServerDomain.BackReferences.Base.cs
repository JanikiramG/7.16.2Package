namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MailServerDomain

	/// <exclude/>
	public class MailServerDomain : Terrasoft.Configuration.MailServerDomain
	{

		#region Constructors: Public

		public MailServerDomain(UserConnection userConnection)
			: base(userConnection) {
		}

		public MailServerDomain(Terrasoft.Configuration.MailServerDomain source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

