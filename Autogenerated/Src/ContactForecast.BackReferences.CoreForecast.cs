namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactForecast

	/// <exclude/>
	public class ContactForecast : Terrasoft.Configuration.ContactForecast
	{

		#region Constructors: Public

		public ContactForecast(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactForecast(Terrasoft.Configuration.ContactForecast source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

