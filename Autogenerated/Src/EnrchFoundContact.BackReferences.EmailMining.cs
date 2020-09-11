namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EnrchFoundContact

	/// <exclude/>
	public class EnrchFoundContact : Terrasoft.Configuration.EnrchFoundContact
	{

		#region Constructors: Public

		public EnrchFoundContact(UserConnection userConnection)
			: base(userConnection) {
		}

		public EnrchFoundContact(Terrasoft.Configuration.EnrchFoundContact source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

