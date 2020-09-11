namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailRelation

	/// <exclude/>
	public class EmailRelation : Terrasoft.Configuration.EmailRelation
	{

		#region Constructors: Public

		public EmailRelation(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailRelation(Terrasoft.Configuration.EmailRelation source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

