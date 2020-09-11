namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EnrchTypeMapping

	/// <exclude/>
	public class EnrchTypeMapping : Terrasoft.Configuration.EnrchTypeMapping
	{

		#region Constructors: Public

		public EnrchTypeMapping(UserConnection userConnection)
			: base(userConnection) {
		}

		public EnrchTypeMapping(Terrasoft.Configuration.EnrchTypeMapping source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

