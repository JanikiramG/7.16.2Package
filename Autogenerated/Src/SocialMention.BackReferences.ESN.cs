namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialMention

	/// <exclude/>
	public class SocialMention : Terrasoft.Configuration.SocialMention
	{

		#region Constructors: Public

		public SocialMention(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialMention(Terrasoft.Configuration.SocialMention source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

