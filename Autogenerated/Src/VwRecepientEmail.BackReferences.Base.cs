namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwRecepientEmail

	/// <exclude/>
	public class VwRecepientEmail : Terrasoft.Configuration.VwRecepientEmail
	{

		#region Constructors: Public

		public VwRecepientEmail(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwRecepientEmail(Terrasoft.Configuration.VwRecepientEmail source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

