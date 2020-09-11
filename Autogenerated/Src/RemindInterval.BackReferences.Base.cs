namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: RemindInterval

	/// <exclude/>
	public class RemindInterval : Terrasoft.Configuration.RemindInterval
	{

		#region Constructors: Public

		public RemindInterval(UserConnection userConnection)
			: base(userConnection) {
		}

		public RemindInterval(Terrasoft.Configuration.RemindInterval source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

