namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseFolder

	/// <exclude/>
	public class BaseFolder : Terrasoft.Configuration.BaseFolder
	{

		#region Constructors: Public

		public BaseFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseFolder(Terrasoft.Configuration.BaseFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

