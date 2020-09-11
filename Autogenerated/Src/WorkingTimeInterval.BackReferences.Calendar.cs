namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WorkingTimeInterval

	/// <exclude/>
	public class WorkingTimeInterval : Terrasoft.Configuration.WorkingTimeInterval
	{

		#region Constructors: Public

		public WorkingTimeInterval(UserConnection userConnection)
			: base(userConnection) {
		}

		public WorkingTimeInterval(Terrasoft.Configuration.WorkingTimeInterval source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

