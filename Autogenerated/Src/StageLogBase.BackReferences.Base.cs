namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: StageLogBase

	/// <exclude/>
	public class StageLogBase : Terrasoft.Configuration.StageLogBase
	{

		#region Constructors: Public

		public StageLogBase(UserConnection userConnection)
			: base(userConnection) {
		}

		public StageLogBase(Terrasoft.Configuration.StageLogBase source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

