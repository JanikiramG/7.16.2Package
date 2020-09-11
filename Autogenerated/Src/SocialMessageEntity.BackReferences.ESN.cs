namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialMessageEntity

	/// <exclude/>
	public class SocialMessageEntity : Terrasoft.Configuration.SocialMessageEntity
	{

		#region Constructors: Public

		public SocialMessageEntity(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialMessageEntity(Terrasoft.Configuration.SocialMessageEntity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

