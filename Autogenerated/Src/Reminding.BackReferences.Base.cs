namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Reminding

	/// <exclude/>
	public class Reminding : Terrasoft.Configuration.Reminding
	{

		#region Constructors: Public

		public Reminding(UserConnection userConnection)
			: base(userConnection) {
		}

		public Reminding(Terrasoft.Configuration.Reminding source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

