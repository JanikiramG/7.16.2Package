namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPrcActivityLinks

	/// <exclude/>
	public class SysPrcActivityLinks : Terrasoft.Configuration.SysPrcActivityLinks
	{

		#region Constructors: Public

		public SysPrcActivityLinks(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPrcActivityLinks(Terrasoft.Configuration.SysPrcActivityLinks source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

