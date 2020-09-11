namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CallFile

	/// <exclude/>
	public class CallFile : Terrasoft.Configuration.CallFile
	{

		#region Constructors: Public

		public CallFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public CallFile(Terrasoft.Configuration.CallFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

