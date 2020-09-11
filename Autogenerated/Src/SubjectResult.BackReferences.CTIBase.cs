namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SubjectResult

	/// <exclude/>
	public class SubjectResult : Terrasoft.Configuration.SubjectResult
	{

		#region Constructors: Public

		public SubjectResult(UserConnection userConnection)
			: base(userConnection) {
		}

		public SubjectResult(Terrasoft.Configuration.SubjectResult source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

