namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLModelTag

	/// <exclude/>
	public class MLModelTag : Terrasoft.Configuration.MLModelTag
	{

		#region Constructors: Public

		public MLModelTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLModelTag(Terrasoft.Configuration.MLModelTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MLModelInTag> MLModelInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

