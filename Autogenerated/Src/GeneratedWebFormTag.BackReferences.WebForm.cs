namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: GeneratedWebFormTag

	/// <exclude/>
	public class GeneratedWebFormTag : Terrasoft.Configuration.GeneratedWebFormTag
	{

		#region Constructors: Public

		public GeneratedWebFormTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public GeneratedWebFormTag(Terrasoft.Configuration.GeneratedWebFormTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<GeneratedWebFormInTag> GeneratedWebFormInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

