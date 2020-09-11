namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProcessSchemaType

	/// <exclude/>
	public class ProcessSchemaType : Terrasoft.Configuration.ProcessSchemaType
	{

		#region Constructors: Public

		public ProcessSchemaType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProcessSchemaType(Terrasoft.Configuration.ProcessSchemaType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwProcessLib> VwProcessLibCollectionByProcessSchemaType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

