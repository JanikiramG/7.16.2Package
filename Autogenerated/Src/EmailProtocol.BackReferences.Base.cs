namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailProtocol

	/// <exclude/>
	public class EmailProtocol : Terrasoft.Configuration.EmailProtocol
	{

		#region Constructors: Public

		public EmailProtocol(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailProtocol(Terrasoft.Configuration.EmailProtocol source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MailServer> MailServerCollectionByEmailProtocol {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

