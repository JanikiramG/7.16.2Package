namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysAggregationType

	/// <exclude/>
	public class SysAggregationType : Terrasoft.Configuration.SysAggregationType
	{

		#region Constructors: Public

		public SysAggregationType(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysAggregationType(Terrasoft.Configuration.SysAggregationType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

