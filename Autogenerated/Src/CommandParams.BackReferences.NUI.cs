namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CommandParams

	/// <exclude/>
	public class CommandParams : Terrasoft.Configuration.CommandParams
	{

		#region Constructors: Public

		public CommandParams(UserConnection userConnection)
			: base(userConnection) {
		}

		public CommandParams(Terrasoft.Configuration.CommandParams source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

