namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PeriodicitySettings

	/// <exclude/>
	public class PeriodicitySettings : Terrasoft.Configuration.PeriodicitySettings
	{

		#region Constructors: Public

		public PeriodicitySettings(UserConnection userConnection)
			: base(userConnection) {
		}

		public PeriodicitySettings(Terrasoft.Configuration.PeriodicitySettings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

