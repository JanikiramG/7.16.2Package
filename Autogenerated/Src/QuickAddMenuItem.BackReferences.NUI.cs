namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: QuickAddMenuItem

	/// <exclude/>
	public class QuickAddMenuItem : Terrasoft.Configuration.QuickAddMenuItem
	{

		#region Constructors: Public

		public QuickAddMenuItem(UserConnection userConnection)
			: base(userConnection) {
		}

		public QuickAddMenuItem(Terrasoft.Configuration.QuickAddMenuItem source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

