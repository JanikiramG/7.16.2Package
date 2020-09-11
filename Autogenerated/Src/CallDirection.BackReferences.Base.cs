namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CallDirection

	/// <exclude/>
	public class CallDirection : Terrasoft.Configuration.CallDirection
	{

		#region Constructors: Public

		public CallDirection(UserConnection userConnection)
			: base(userConnection) {
		}

		public CallDirection(Terrasoft.Configuration.CallDirection source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByCallDirection {
			get;
			set;
		}

		public IEnumerable<Call> CallCollectionByDirection {
			get;
			set;
		}

		public IEnumerable<SysActiveCall> SysActiveCallCollectionByDirection {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

