namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WorkResourceElement

	/// <exclude/>
	public class WorkResourceElement : Terrasoft.Configuration.WorkResourceElement
	{

		#region Constructors: Public

		public WorkResourceElement(UserConnection userConnection)
			: base(userConnection) {
		}

		public WorkResourceElement(Terrasoft.Configuration.WorkResourceElement source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

