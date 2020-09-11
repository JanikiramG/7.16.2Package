namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailMessageData

	/// <exclude/>
	public class EmailMessageData : Terrasoft.Configuration.EmailMessageData
	{

		#region Constructors: Public

		public EmailMessageData(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailMessageData(Terrasoft.Configuration.EmailMessageData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<EmailMessageData> EmailMessageDataCollectionByParentMessage {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

