namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProcessInModules

	/// <exclude/>
	public class ProcessInModules : Terrasoft.Configuration.ProcessInModules
	{

		#region Constructors: Public

		public ProcessInModules(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProcessInModules(Terrasoft.Configuration.ProcessInModules source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

