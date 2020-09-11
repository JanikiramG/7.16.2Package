namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DiagramElement

	/// <exclude/>
	public class DiagramElement : Terrasoft.Configuration.DiagramElement
	{

		#region Constructors: Public

		public DiagramElement(UserConnection userConnection)
			: base(userConnection) {
		}

		public DiagramElement(Terrasoft.Configuration.DiagramElement source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

