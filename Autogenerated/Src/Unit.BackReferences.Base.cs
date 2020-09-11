namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Unit

	/// <exclude/>
	public class Unit : Terrasoft.Configuration.Unit
	{

		#region Constructors: Public

		public Unit(UserConnection userConnection)
			: base(userConnection) {
		}

		public Unit(Terrasoft.Configuration.Unit source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<DocumentProduct> DocumentProductCollectionByUnit {
			get;
			set;
		}

		public IEnumerable<InvoiceProduct> InvoiceProductCollectionByUnit {
			get;
			set;
		}

		public IEnumerable<OrderProduct> OrderProductCollectionByUnit {
			get;
			set;
		}

		public IEnumerable<Product> ProductCollectionByUnit {
			get;
			set;
		}

		public IEnumerable<ProductUnit> ProductUnitCollectionByUnit {
			get;
			set;
		}

		public IEnumerable<ProjectProduct> ProjectProductCollectionByUnit {
			get;
			set;
		}

		public IEnumerable<VwDocumentProduct> VwDocumentProductCollectionByUnit {
			get;
			set;
		}

		public IEnumerable<VwInvoiceProduct> VwInvoiceProductCollectionByUnit {
			get;
			set;
		}

		public IEnumerable<VwProjectProduct> VwProjectProductCollectionByUnit {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

