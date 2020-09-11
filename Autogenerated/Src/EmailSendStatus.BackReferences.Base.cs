namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailSendStatus

	/// <exclude/>
	public class EmailSendStatus : Terrasoft.Configuration.EmailSendStatus
	{

		#region Constructors: Public

		public EmailSendStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailSendStatus(Terrasoft.Configuration.EmailSendStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByEmailSendStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

