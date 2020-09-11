namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: StageBase

	/// <exclude/>
	public class StageBase : Terrasoft.Configuration.StageBase
	{

		#region Constructors: Public

		public StageBase(UserConnection userConnection)
			: base(userConnection) {
		}

		public StageBase(Terrasoft.Configuration.StageBase source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

