namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MessagePublisherBySection

	/// <exclude/>
	public class MessagePublisherBySection : Terrasoft.Configuration.MessagePublisherBySection
	{

		#region Constructors: Public

		public MessagePublisherBySection(UserConnection userConnection)
			: base(userConnection) {
		}

		public MessagePublisherBySection(Terrasoft.Configuration.MessagePublisherBySection source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

