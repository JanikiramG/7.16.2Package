namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwEntityInProcess

	/// <exclude/>
	public class VwEntityInProcess : Terrasoft.Configuration.VwEntityInProcess
	{

		#region Constructors: Public

		public VwEntityInProcess(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwEntityInProcess(Terrasoft.Configuration.VwEntityInProcess source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

