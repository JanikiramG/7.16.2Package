namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EntryPoint

	/// <exclude/>
	public class EntryPoint : Terrasoft.Configuration.EntryPoint
	{

		#region Constructors: Public

		public EntryPoint(UserConnection userConnection)
			: base(userConnection) {
		}

		public EntryPoint(Terrasoft.Configuration.EntryPoint source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

