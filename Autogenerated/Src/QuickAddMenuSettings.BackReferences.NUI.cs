namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: QuickAddMenuSettings

	/// <exclude/>
	public class QuickAddMenuSettings : Terrasoft.Configuration.QuickAddMenuSettings
	{

		#region Constructors: Public

		public QuickAddMenuSettings(UserConnection userConnection)
			: base(userConnection) {
		}

		public QuickAddMenuSettings(Terrasoft.Configuration.QuickAddMenuSettings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<QuickAddMenuItem> QuickAddMenuItemCollectionByQuickAddMenuSettings {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

