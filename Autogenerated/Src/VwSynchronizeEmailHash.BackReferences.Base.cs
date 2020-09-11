namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSynchronizeEmailHash

	/// <exclude/>
	public class VwSynchronizeEmailHash : Terrasoft.Configuration.VwSynchronizeEmailHash
	{

		#region Constructors: Public

		public VwSynchronizeEmailHash(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSynchronizeEmailHash(Terrasoft.Configuration.VwSynchronizeEmailHash source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

