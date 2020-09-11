namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EditPageModification

	/// <exclude/>
	public class EditPageModification : Terrasoft.Configuration.EditPageModification
	{

		#region Constructors: Public

		public EditPageModification(UserConnection userConnection)
			: base(userConnection) {
		}

		public EditPageModification(Terrasoft.Configuration.EditPageModification source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

