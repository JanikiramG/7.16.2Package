namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DisplayDateFormat

	/// <exclude/>
	public class DisplayDateFormat : Terrasoft.Configuration.DisplayDateFormat
	{

		#region Constructors: Public

		public DisplayDateFormat(UserConnection userConnection)
			: base(userConnection) {
		}

		public DisplayDateFormat(Terrasoft.Configuration.DisplayDateFormat source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

