namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EnrchFoundAccount

	/// <exclude/>
	public class EnrchFoundAccount : Terrasoft.Configuration.EnrchFoundAccount
	{

		#region Constructors: Public

		public EnrchFoundAccount(UserConnection userConnection)
			: base(userConnection) {
		}

		public EnrchFoundAccount(Terrasoft.Configuration.EnrchFoundAccount source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

