namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ExternalAccessTag

	/// <exclude/>
	public class ExternalAccessTag : Terrasoft.Configuration.ExternalAccessTag
	{

		#region Constructors: Public

		public ExternalAccessTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ExternalAccessTag(Terrasoft.Configuration.ExternalAccessTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ExternalAccessInTag> ExternalAccessInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

