using System;
using System.Collections.Generic;

namespace Terrasoft.Configuration
{
	/// <summary>
	/// Contains constants for Activity object.
	/// </summary>
	public static class ActivityConsts
	{
		/// <summary>
		/// UId activity schema.
		/// </summary>
		public static readonly Guid ActivityEntitySchemaUId = new Guid("C449D832-A4CC-4B01-B9D5-8A12C42A9F89");

		/// <summary>
		/// Activity status - Completed
		/// </summary>
		public static readonly Guid CompletedStatusUId = new Guid("4BDBB88F-58E6-DF11-971B-001D60E938C6");

		/// <summary>
		/// Activity status - Canceled
		/// </summary>
		public static readonly Guid CanceledStatusUId = new Guid("201CFBA8-58E6-DF11-971B-001D60E938C6");

		/// <summary>
		/// Activity status - New status
		/// <summary>
		public static readonly Guid NewStatusUId = new Guid("384D4B84-58E6-DF11-971B-001D60E938C6");

		/// <summary>
		/// Activity status - InProgress
		/// <summary>
		public static readonly Guid InProgressUId = new Guid("394D4B84-58E6-DF11-971B-001D60E938C6");

		/// <summary>
		/// Activity type - Email
		/// </summary>
		public static readonly Guid EmailTypeUId = new Guid("E2831DEC-CFC0-DF11-B00F-001D60E938C6");

		/// <summary>
		/// Activity type - Task
		/// </summary>
		public static readonly Guid TaskTypeUId = new Guid("FBE0ACDC-CFC0-DF11-B00F-001D60E938C6");

		/// <summary>
		/// Activity type - Call
		/// </summary>
		public static readonly Guid CallTypeUId = new Guid("E1831DEC-CFC0-DF11-B00F-001D60E938C6");

		/// <summary>
		/// Activity type - Visit
		/// </summary>
		public static readonly Guid VisitTypeUId = new Guid("E3831DEC-CFC0-DF11-B00F-001D60E938C6");

		/// <summary>
		/// Email type - Code = "Incoming"
		/// </summary>
		public static readonly Guid IncomingEmailTypeId = new Guid("7F9D1F86-F36B-1410-068C-20CF30B39373");
		
		/// <summary>
		/// Email type - Code = "Outgoing"
		/// </summary>
		public static readonly Guid OutgoingEmailTypeId = new Guid("7F6D3F94-F36B-1410-068C-20CF30B39373");

		/// <summary>
		/// E-mail sending status - Code = "Sended"
		/// </summary>
		public static readonly Guid SendedEmailStatusId = new Guid("8074FFC0-6107-E011-A646-16D83CAB0980");

		/// <summary>
		/// E-mail sending status - Code = "NotSend"
		/// </summary>
		public static readonly Guid NotSendEmailStatusId = new Guid("20C0C460-6107-E011-A646-16D83CAB0980");

		/// <summary>
		/// E-mail sending status  - Code = "Opened"
		/// </summary>
		public static readonly Guid OpenedEmailStatusId = new Guid("7459545A-9229-4EE7-B501-03B8A50E2B39");

		/// <summary>
		/// E-mail sending status  - Code = "InProgress"
		/// </summary>
		public static readonly Guid InProgressEmailStatusId = new Guid("603BA6AF-6107-E011-A646-16D83CAB0980");

		/// <summary>
		/// Activity category - Name = "E-mail"
		/// </summary>
		public static readonly Guid EmailActivityCategoryId = new Guid("8038A396-7825-E011-8165-00155D043204");

		/// <summary>
		/// Activity category - Name = "Appointment"
		/// </summary>
		public static readonly Guid AppointmentActivityCategoryId = new Guid("42C74C49-58E6-DF11-971B-001D60E938C6");
		
		/// <summary>
		/// Activity category - Name = "To do"
		/// </summary>
		public static readonly Guid TaskCategoryId = new Guid("F51C4643-58E6-DF11-971B-001D60E938C6");

		/// <summary>
		/// Activity participant invite response - Confirmed.
		/// </summary>
		public static readonly Guid ParticipantResponseConfirmedId = new Guid("7098C892-34E3-4A3E-AF08-C1A139F63220");

		/// <summary>
		/// Activity participant invite response - Declined.
		/// </summary>
		public static readonly Guid ParticipantResponseDeclinedId = new Guid("CC256758-4051-4021-9C51-216E37635C46");

		/// <summary>
		/// Activity participant invite response - In doubt.
		/// </summary>
		public static readonly Guid ParticipantResponseInDoubtId = new Guid("50E89724-522D-446E-BE91-12548B8C834D");

		/// <summary>
		/// Account column name.
		/// </summary>
		public static readonly string accountColumnName = "Contact";
		
		/// <summary>
		/// Contact column name.
		/// </summary>
		public static readonly string contactColumnName = "Account";
		
		/// <summary>
		/// Opportunity column name.
		/// </summary>
		public static readonly string opportunityColumnName = "Opportunity";
		
		/// <summary>
		/// Document column name.
		/// </summary>
		public static readonly string documentColumnName = "Document";
		
		/// <summary>
		/// Activity column name.
		/// </summary>
		public static readonly string activiteColumnName = "Activity"; 

		/// <summary>
		/// Name columns collection in Activity schema.
		/// </summary>
		public static readonly  List<string> listColumnName = new List<string>() {
			accountColumnName,
			contactColumnName,
			opportunityColumnName,
			documentColumnName,
			activiteColumnName
		};

		/// <summary>
		/// Activity result positive category UId.
		/// </summary>
		public static readonly Guid PositiveActivityResultCategoryId = new Guid("1D2E48F2-C5FD-417D-9551-30E71F35DF3D");

	}
}
