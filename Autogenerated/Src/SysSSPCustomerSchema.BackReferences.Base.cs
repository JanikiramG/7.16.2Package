namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSSPCustomerSchema

	/// <exclude/>
	public class SysSSPCustomerSchema : Terrasoft.Configuration.SysSSPCustomerSchema
	{

		#region Constructors: Public

		public SysSSPCustomerSchema(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSSPCustomerSchema(Terrasoft.Configuration.SysSSPCustomerSchema source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

