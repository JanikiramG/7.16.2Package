namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: QualifyStatusDecoupling

	/// <exclude/>
	public class QualifyStatusDecoupling : Terrasoft.Configuration.QualifyStatusDecoupling
	{

		#region Constructors: Public

		public QualifyStatusDecoupling(UserConnection userConnection)
			: base(userConnection) {
		}

		public QualifyStatusDecoupling(Terrasoft.Configuration.QualifyStatusDecoupling source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

