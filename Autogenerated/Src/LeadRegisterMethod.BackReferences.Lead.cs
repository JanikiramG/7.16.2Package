namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadRegisterMethod

	/// <exclude/>
	public class LeadRegisterMethod : Terrasoft.Configuration.LeadRegisterMethod
	{

		#region Constructors: Public

		public LeadRegisterMethod(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadRegisterMethod(Terrasoft.Configuration.LeadRegisterMethod source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Lead> LeadCollectionByRegisterMethod {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

