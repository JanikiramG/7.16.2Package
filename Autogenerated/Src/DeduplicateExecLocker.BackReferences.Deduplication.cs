namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DeduplicateExecLocker

	/// <exclude/>
	public class DeduplicateExecLocker : Terrasoft.Configuration.DeduplicateExecLocker
	{

		#region Constructors: Public

		public DeduplicateExecLocker(UserConnection userConnection)
			: base(userConnection) {
		}

		public DeduplicateExecLocker(Terrasoft.Configuration.DeduplicateExecLocker source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

