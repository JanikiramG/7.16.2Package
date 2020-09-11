namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwUserEmailsCount

	/// <exclude/>
	public class VwUserEmailsCount : Terrasoft.Configuration.VwUserEmailsCount
	{

		#region Constructors: Public

		public VwUserEmailsCount(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwUserEmailsCount(Terrasoft.Configuration.VwUserEmailsCount source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

