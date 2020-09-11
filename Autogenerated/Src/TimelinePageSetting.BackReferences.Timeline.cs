namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: TimelinePageSetting

	/// <exclude/>
	public class TimelinePageSetting : Terrasoft.Configuration.TimelinePageSetting
	{

		#region Constructors: Public

		public TimelinePageSetting(UserConnection userConnection)
			: base(userConnection) {
		}

		public TimelinePageSetting(Terrasoft.Configuration.TimelinePageSetting source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

