namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSolution

	/// <exclude/>
	public class SysSolution : Terrasoft.Configuration.SysSolution
	{

		#region Constructors: Public

		public SysSolution(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSolution(Terrasoft.Configuration.SysSolution source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

