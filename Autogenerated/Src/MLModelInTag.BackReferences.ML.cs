namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLModelInTag

	/// <exclude/>
	public class MLModelInTag : Terrasoft.Configuration.MLModelInTag
	{

		#region Constructors: Public

		public MLModelInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLModelInTag(Terrasoft.Configuration.MLModelInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

