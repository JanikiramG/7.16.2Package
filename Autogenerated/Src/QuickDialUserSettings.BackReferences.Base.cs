namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: QuickDialUserSettings

	/// <exclude/>
	public class QuickDialUserSettings : Terrasoft.Configuration.QuickDialUserSettings
	{

		#region Constructors: Public

		public QuickDialUserSettings(UserConnection userConnection)
			: base(userConnection) {
		}

		public QuickDialUserSettings(Terrasoft.Configuration.QuickDialUserSettings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

