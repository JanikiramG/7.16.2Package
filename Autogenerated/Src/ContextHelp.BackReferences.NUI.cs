namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContextHelp

	/// <exclude/>
	public class ContextHelp : Terrasoft.Configuration.ContextHelp
	{

		#region Constructors: Public

		public ContextHelp(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContextHelp(Terrasoft.Configuration.ContextHelp source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

