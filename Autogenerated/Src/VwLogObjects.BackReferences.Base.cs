namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwLogObjects

	/// <exclude/>
	public class VwLogObjects : Terrasoft.Configuration.VwLogObjects
	{

		#region Constructors: Public

		public VwLogObjects(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwLogObjects(Terrasoft.Configuration.VwLogObjects source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

