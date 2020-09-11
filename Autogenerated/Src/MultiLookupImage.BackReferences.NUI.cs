namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MultiLookupImage

	/// <exclude/>
	public class MultiLookupImage : Terrasoft.Configuration.MultiLookupImage
	{

		#region Constructors: Public

		public MultiLookupImage(UserConnection userConnection)
			: base(userConnection) {
		}

		public MultiLookupImage(Terrasoft.Configuration.MultiLookupImage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

