namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Macros

	/// <exclude/>
	public class Macros : Terrasoft.Configuration.Macros
	{

		#region Constructors: Public

		public Macros(UserConnection userConnection)
			: base(userConnection) {
		}

		public Macros(Terrasoft.Configuration.Macros source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

