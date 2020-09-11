namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseItemInFolder

	/// <exclude/>
	public class BaseItemInFolder : Terrasoft.Configuration.BaseItemInFolder
	{

		#region Constructors: Public

		public BaseItemInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseItemInFolder(Terrasoft.Configuration.BaseItemInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

