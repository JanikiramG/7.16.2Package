namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseEntityNotes

	/// <exclude/>
	public class BaseEntityNotes : Terrasoft.Configuration.BaseEntityNotes
	{

		#region Constructors: Public

		public BaseEntityNotes(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseEntityNotes(Terrasoft.Configuration.BaseEntityNotes source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

