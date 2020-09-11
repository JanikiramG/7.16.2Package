namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LookupInTag

	/// <exclude/>
	public class LookupInTag : Terrasoft.Configuration.LookupInTag
	{

		#region Constructors: Public

		public LookupInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public LookupInTag(Terrasoft.Configuration.LookupInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

