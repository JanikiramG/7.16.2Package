namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VirtualEmailTplContent

	/// <exclude/>
	public class VirtualEmailTplContent : Terrasoft.Configuration.VirtualEmailTplContent
	{

		#region Constructors: Public

		public VirtualEmailTplContent(UserConnection userConnection)
			: base(userConnection) {
		}

		public VirtualEmailTplContent(Terrasoft.Configuration.VirtualEmailTplContent source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

