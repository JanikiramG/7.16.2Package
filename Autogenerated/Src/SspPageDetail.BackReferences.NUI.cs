namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SspPageDetail

	/// <exclude/>
	public class SspPageDetail : Terrasoft.Configuration.SspPageDetail
	{

		#region Constructors: Public

		public SspPageDetail(UserConnection userConnection)
			: base(userConnection) {
		}

		public SspPageDetail(Terrasoft.Configuration.SspPageDetail source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

