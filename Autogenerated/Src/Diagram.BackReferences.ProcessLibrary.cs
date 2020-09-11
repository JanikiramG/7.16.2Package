namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Diagram

	/// <exclude/>
	public class Diagram : Terrasoft.Configuration.Diagram
	{

		#region Constructors: Public

		public Diagram(UserConnection userConnection)
			: base(userConnection) {
		}

		public Diagram(Terrasoft.Configuration.Diagram source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

