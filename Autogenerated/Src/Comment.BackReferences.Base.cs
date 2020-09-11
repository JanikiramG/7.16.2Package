namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Comment

	/// <exclude/>
	public class Comment : Terrasoft.Configuration.Comment
	{

		#region Constructors: Public

		public Comment(UserConnection userConnection)
			: base(userConnection) {
		}

		public Comment(Terrasoft.Configuration.Comment source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

