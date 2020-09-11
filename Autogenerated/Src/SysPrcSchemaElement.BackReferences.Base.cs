namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPrcSchemaElement

	/// <exclude/>
	public class SysPrcSchemaElement : Terrasoft.Configuration.SysPrcSchemaElement
	{

		#region Constructors: Public

		public SysPrcSchemaElement(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPrcSchemaElement(Terrasoft.Configuration.SysPrcSchemaElement source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwSysProcessMILog> VwSysProcessMILogCollectionByIteratorElement {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

