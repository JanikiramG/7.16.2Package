namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MailServerType

	/// <exclude/>
	public class MailServerType : Terrasoft.Configuration.MailServerType
	{

		#region Constructors: Public

		public MailServerType(UserConnection userConnection)
			: base(userConnection) {
		}

		public MailServerType(Terrasoft.Configuration.MailServerType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MailServer> MailServerCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

