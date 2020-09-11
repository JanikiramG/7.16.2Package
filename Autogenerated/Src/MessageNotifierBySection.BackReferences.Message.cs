namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MessageNotifierBySection

	/// <exclude/>
	public class MessageNotifierBySection : Terrasoft.Configuration.MessageNotifierBySection
	{

		#region Constructors: Public

		public MessageNotifierBySection(UserConnection userConnection)
			: base(userConnection) {
		}

		public MessageNotifierBySection(Terrasoft.Configuration.MessageNotifierBySection source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

