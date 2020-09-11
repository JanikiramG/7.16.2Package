namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: TimeUnit

	/// <exclude/>
	public class TimeUnit : Terrasoft.Configuration.TimeUnit
	{

		#region Constructors: Public

		public TimeUnit(UserConnection userConnection)
			: base(userConnection) {
		}

		public TimeUnit(Terrasoft.Configuration.TimeUnit source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

