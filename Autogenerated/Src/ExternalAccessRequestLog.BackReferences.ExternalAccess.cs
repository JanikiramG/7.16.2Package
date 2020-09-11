namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ExternalAccessRequestLog

	/// <exclude/>
	public class ExternalAccessRequestLog : Terrasoft.Configuration.ExternalAccessRequestLog
	{

		#region Constructors: Public

		public ExternalAccessRequestLog(UserConnection userConnection)
			: base(userConnection) {
		}

		public ExternalAccessRequestLog(Terrasoft.Configuration.ExternalAccessRequestLog source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

