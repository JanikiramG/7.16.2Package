namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysOrderDirection

	/// <exclude/>
	public class SysOrderDirection : Terrasoft.Configuration.SysOrderDirection
	{

		#region Constructors: Public

		public SysOrderDirection(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysOrderDirection(Terrasoft.Configuration.SysOrderDirection source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysLookupColumn> SysLookupColumnCollectionBySysOrderDirection {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

