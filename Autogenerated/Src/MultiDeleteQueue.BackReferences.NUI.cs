namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MultiDeleteQueue

	/// <exclude/>
	public class MultiDeleteQueue : Terrasoft.Configuration.MultiDeleteQueue
	{

		#region Constructors: Public

		public MultiDeleteQueue(UserConnection userConnection)
			: base(userConnection) {
		}

		public MultiDeleteQueue(Terrasoft.Configuration.MultiDeleteQueue source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

