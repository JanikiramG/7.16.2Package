namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LookupTag

	/// <exclude/>
	public class LookupTag : Terrasoft.Configuration.LookupTag
	{

		#region Constructors: Public

		public LookupTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public LookupTag(Terrasoft.Configuration.LookupTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<LookupInTag> LookupInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

