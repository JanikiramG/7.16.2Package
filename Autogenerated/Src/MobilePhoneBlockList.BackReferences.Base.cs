namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MobilePhoneBlockList

	/// <exclude/>
	public class MobilePhoneBlockList : Terrasoft.Configuration.MobilePhoneBlockList
	{

		#region Constructors: Public

		public MobilePhoneBlockList(UserConnection userConnection)
			: base(userConnection) {
		}

		public MobilePhoneBlockList(Terrasoft.Configuration.MobilePhoneBlockList source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

