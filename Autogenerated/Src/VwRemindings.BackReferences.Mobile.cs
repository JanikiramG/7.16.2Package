namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwRemindings

	/// <exclude/>
	public class VwRemindings : Terrasoft.Configuration.VwRemindings
	{

		#region Constructors: Public

		public VwRemindings(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwRemindings(Terrasoft.Configuration.VwRemindings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

