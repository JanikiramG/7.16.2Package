namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LendingState

	/// <exclude/>
	public class LendingState : Terrasoft.Configuration.LendingState
	{

		#region Constructors: Public

		public LendingState(UserConnection userConnection)
			: base(userConnection) {
		}

		public LendingState(Terrasoft.Configuration.LendingState source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<GeneratedWebForm> GeneratedWebFormCollectionByState {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

