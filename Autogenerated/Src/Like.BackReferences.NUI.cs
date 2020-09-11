namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Like

	/// <exclude/>
	public class Like : Terrasoft.Configuration.Like
	{

		#region Constructors: Public

		public Like(UserConnection userConnection)
			: base(userConnection) {
		}

		public Like(Terrasoft.Configuration.Like source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

