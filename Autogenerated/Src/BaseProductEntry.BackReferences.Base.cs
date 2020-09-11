namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseProductEntry

	/// <exclude/>
	public class BaseProductEntry : Terrasoft.Configuration.BaseProductEntry
	{

		#region Constructors: Public

		public BaseProductEntry(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseProductEntry(Terrasoft.Configuration.BaseProductEntry source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

