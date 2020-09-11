namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Month

	/// <exclude/>
	public class Month : Terrasoft.Configuration.Month
	{

		#region Constructors: Public

		public Month(UserConnection userConnection)
			: base(userConnection) {
		}

		public Month(Terrasoft.Configuration.Month source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

