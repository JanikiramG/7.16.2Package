using System;
using Terrasoft.Core;
using System.Threading.Tasks;
using Terrasoft.Common;
using System.Collections.Generic;
using System.Linq;

namespace Terrasoft.Configuration
{

	#region Class: LeadMessageListener

	public class LeadMessageListener : BaseMessageListener
	{
		
		#region Fields: Private

		#endregion

		#region Constructor: Public

		public LeadMessageListener(UserConnection userConnection) : base(userConnection) {
			HistorySchemaName = "LeadMessageHistory";
			HistorySchemaReferenceColumnName = "LeadId";
			ListenerSchemaUId = LeadConsts.LeadShemaUId;
			NeedCheckExistenceOfRecord = true;
		}

		#endregion
	}

	#endregion

}
