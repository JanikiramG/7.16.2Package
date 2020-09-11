namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MobileData

	/// <exclude/>
	public class MobileData : Terrasoft.Configuration.MobileData
	{

		#region Constructors: Public

		public MobileData(UserConnection userConnection)
			: base(userConnection) {
		}

		public MobileData(Terrasoft.Configuration.MobileData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

