namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PaymentMethod

	/// <exclude/>
	public class PaymentMethod : Terrasoft.Configuration.PaymentMethod
	{

		#region Constructors: Public

		public PaymentMethod(UserConnection userConnection)
			: base(userConnection) {
		}

		public PaymentMethod(Terrasoft.Configuration.PaymentMethod source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<EducationActivity> EducationActivityCollectionByPaymentMethod {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

