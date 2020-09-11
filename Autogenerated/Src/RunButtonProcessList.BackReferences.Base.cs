namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: RunButtonProcessList

	/// <exclude/>
	public class RunButtonProcessList : Terrasoft.Configuration.RunButtonProcessList
	{

		#region Constructors: Public

		public RunButtonProcessList(UserConnection userConnection)
			: base(userConnection) {
		}

		public RunButtonProcessList(Terrasoft.Configuration.RunButtonProcessList source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

