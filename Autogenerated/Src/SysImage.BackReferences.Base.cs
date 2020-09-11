namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysImage

	/// <exclude/>
	public class SysImage : Terrasoft.Configuration.SysImage
	{

		#region Constructors: Public

		public SysImage(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysImage(Terrasoft.Configuration.SysImage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByAccountLogo {
			get;
			set;
		}

		public IEnumerable<CallDirection> CallDirectionCollectionByImage {
			get;
			set;
		}

		public IEnumerable<Contact> ContactCollectionByPhoto {
			get;
			set;
		}

		public IEnumerable<ContentBlock> ContentBlockCollectionByImage {
			get;
			set;
		}

		public IEnumerable<ContentUserBlock> ContentUserBlockCollectionByImage {
			get;
			set;
		}

		public IEnumerable<EmailTemplate> EmailTemplateCollectionByPreviewImage {
			get;
			set;
		}

		public IEnumerable<ESNNotificationType> ESNNotificationTypeCollectionByIcon {
			get;
			set;
		}

		public IEnumerable<FolderType> FolderTypeCollectionByImage {
			get;
			set;
		}

		public IEnumerable<LeadType> LeadTypeCollectionByImage {
			get;
			set;
		}

		public IEnumerable<MailServer> MailServerCollectionByLogo {
			get;
			set;
		}

		public IEnumerable<MessagePublisher> MessagePublisherCollectionByImage {
			get;
			set;
		}

		public IEnumerable<MultiLookupImage> MultiLookupImageCollectionByLookupImage {
			get;
			set;
		}

		public IEnumerable<NotificationsSettings> NotificationsSettingsCollectionBySysImage {
			get;
			set;
		}

		public IEnumerable<OAuthApplications> OAuthApplicationsCollectionByImage {
			get;
			set;
		}

		public IEnumerable<OpportunityMood> OpportunityMoodCollectionByImage {
			get;
			set;
		}

		public IEnumerable<PageTemplate> PageTemplateCollectionByPreviewImage {
			get;
			set;
		}

		public IEnumerable<Portal_SysModule> Portal_SysModuleCollectionByImage32 {
			get;
			set;
		}

		public IEnumerable<Portal_SysModule> Portal_SysModuleCollectionByLogo {
			get;
			set;
		}

		public IEnumerable<Product> ProductCollectionByPicture {
			get;
			set;
		}

		public IEnumerable<SocialChannel> SocialChannelCollectionByImage {
			get;
			set;
		}

		public IEnumerable<SysChartSeriesKind> SysChartSeriesKindCollectionByImage {
			get;
			set;
		}

		public IEnumerable<SysCulture> SysCultureCollectionByImage {
			get;
			set;
		}

		public IEnumerable<SysModule> SysModuleCollectionByImage32 {
			get;
			set;
		}

		public IEnumerable<SysModule> SysModuleCollectionByLogo {
			get;
			set;
		}

		public IEnumerable<SysModuleAnalyticsReport> SysModuleAnalyticsReportCollectionByLogo {
			get;
			set;
		}

		public IEnumerable<SysMsgUserState> SysMsgUserStateCollectionByImage {
			get;
			set;
		}

		public IEnumerable<SysMsgUserStateReason> SysMsgUserStateReasonCollectionByImage {
			get;
			set;
		}

		public IEnumerable<SysOperationResult> SysOperationResultCollectionByImage {
			get;
			set;
		}

		public IEnumerable<SysProcessUserTask> SysProcessUserTaskCollectionBySysImage {
			get;
			set;
		}

		public IEnumerable<VwPageTemplate> VwPageTemplateCollectionByPreviewImage {
			get;
			set;
		}

		public IEnumerable<VwProcessLib> VwProcessLibCollectionByStartOptionsImage {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

