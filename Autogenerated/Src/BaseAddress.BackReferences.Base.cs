namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseAddress

	/// <exclude/>
	public class BaseAddress : Terrasoft.Configuration.BaseAddress
	{

		#region Constructors: Public

		public BaseAddress(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseAddress(Terrasoft.Configuration.BaseAddress source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

