namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContextElement

	/// <exclude/>
	public class ContextElement : Terrasoft.Configuration.ContextElement
	{

		#region Constructors: Public

		public ContextElement(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContextElement(Terrasoft.Configuration.ContextElement source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

