namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MobileApplicationMode

	/// <exclude/>
	public class MobileApplicationMode : Terrasoft.Configuration.MobileApplicationMode
	{

		#region Constructors: Public

		public MobileApplicationMode(UserConnection userConnection)
			: base(userConnection) {
		}

		public MobileApplicationMode(Terrasoft.Configuration.MobileApplicationMode source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

