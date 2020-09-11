namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseImageLookup

	/// <exclude/>
	public class BaseImageLookup : Terrasoft.Configuration.BaseImageLookup
	{

		#region Constructors: Public

		public BaseImageLookup(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseImageLookup(Terrasoft.Configuration.BaseImageLookup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

