namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityFile

	/// <exclude/>
	public class OpportunityFile : Terrasoft.Configuration.OpportunityFile
	{

		#region Constructors: Public

		public OpportunityFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityFile(Terrasoft.Configuration.OpportunityFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

