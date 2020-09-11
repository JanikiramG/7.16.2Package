namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysDetail

	/// <exclude/>
	public class SysDetail : Terrasoft.Configuration.SysDetail
	{

		#region Constructors: Public

		public SysDetail(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysDetail(Terrasoft.Configuration.SysDetail source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ProcessInDetails> ProcessInDetailsCollectionBySysDetail {
			get;
			set;
		}

		public IEnumerable<SspPageDetail> SspPageDetailCollectionBySysDetail {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

