﻿namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProcessLogInFolder

	/// <exclude/>
	public class SysProcessLogInFolder : Terrasoft.Configuration.SysProcessLogInFolder
	{

		#region Constructors: Public

		public SysProcessLogInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProcessLogInFolder(Terrasoft.Configuration.SysProcessLogInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

