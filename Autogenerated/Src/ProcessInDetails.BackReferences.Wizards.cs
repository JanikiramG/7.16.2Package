namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProcessInDetails

	/// <exclude/>
	public class ProcessInDetails : Terrasoft.Configuration.ProcessInDetails
	{

		#region Constructors: Public

		public ProcessInDetails(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProcessInDetails(Terrasoft.Configuration.ProcessInDetails source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

