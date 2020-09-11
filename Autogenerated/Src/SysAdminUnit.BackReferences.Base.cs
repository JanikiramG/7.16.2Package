namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysAdminUnit

	/// <exclude/>
	public class SysAdminUnit : Terrasoft.Configuration.SysAdminUnit
	{

		#region Constructors: Public

		public SysAdminUnit(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysAdminUnit(Terrasoft.Configuration.SysAdminUnit source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AdminUnitFeatureState> AdminUnitFeatureStateCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<Calendar> CalendarCollectionByUser {
			get;
			set;
		}

		public IEnumerable<ContractVisa> ContractVisaCollectionByDelegatedFrom {
			get;
			set;
		}

		public IEnumerable<ContractVisa> ContractVisaCollectionByVisaOwner {
			get;
			set;
		}

		public IEnumerable<EmailDefRights> EmailDefRightsCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<FolderFavorite> FolderFavoriteCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<InvoiceVisa> InvoiceVisaCollectionByDelegatedFrom {
			get;
			set;
		}

		public IEnumerable<InvoiceVisa> InvoiceVisaCollectionByVisaOwner {
			get;
			set;
		}

		public IEnumerable<MailboxSyncSettings> MailboxSyncSettingsCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<MultiDeleteQueue> MultiDeleteQueueCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<OAuthApplications> OAuthApplicationsCollectionBySharedUser {
			get;
			set;
		}

		public IEnumerable<OAuthTokenStorage> OAuthTokenStorageCollectionBySysUser {
			get;
			set;
		}

		public IEnumerable<OpportunityDepartment> OpportunityDepartmentCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<OpportunityVisa> OpportunityVisaCollectionByDelegatedFrom {
			get;
			set;
		}

		public IEnumerable<OpportunityVisa> OpportunityVisaCollectionByVisaOwner {
			get;
			set;
		}

		public IEnumerable<OptionalFuncSspRole> OptionalFuncSspRoleCollectionByFuncRole {
			get;
			set;
		}

		public IEnumerable<OptionalFuncSspRole> OptionalFuncSspRoleCollectionByOrgRole {
			get;
			set;
		}

		public IEnumerable<OrderVisa> OrderVisaCollectionByDelegatedFrom {
			get;
			set;
		}

		public IEnumerable<OrderVisa> OrderVisaCollectionByVisaOwner {
			get;
			set;
		}

		public IEnumerable<OrganizationProperty> OrganizationPropertyCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<PushNotificationToken> PushNotificationTokenCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<QuickAddMenuSettings> QuickAddMenuSettingsCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SocialAccount> SocialAccountCollectionByUser {
			get;
			set;
		}

		public IEnumerable<SocialChannelPublisher> SocialChannelPublisherCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SocialFeedFavoriteTpl> SocialFeedFavoriteTplCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SocialLike> SocialLikeCollectionByUser {
			get;
			set;
		}

		public IEnumerable<SocialSubscription> SocialSubscriptionCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SocialUnsubscription> SocialUnsubscriptionCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SysAdminOperationGrantee> SysAdminOperationGranteeCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SysAdminUnit> SysAdminUnitCollectionByParentRole {
			get;
			set;
		}

		public IEnumerable<SysAdminUnitInFolder> SysAdminUnitInFolderCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SysAdminUnitInRole> SysAdminUnitInRoleCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SysAdminUnitInWorkplace> SysAdminUnitInWorkplaceCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SysAdminUnitIPRange> SysAdminUnitIPRangeCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SysFuncRoleInOrgRole> SysFuncRoleInOrgRoleCollectionByFuncRole {
			get;
			set;
		}

		public IEnumerable<SysFuncRoleInOrgRole> SysFuncRoleInOrgRoleCollectionByOrgRole {
			get;
			set;
		}

		public IEnumerable<SysLastUserPassword> SysLastUserPasswordCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SysLicUser> SysLicUserCollectionBySysUser {
			get;
			set;
		}

		public IEnumerable<SysMsgUserSettings> SysMsgUserSettingsCollectionByUser {
			get;
			set;
		}

		public IEnumerable<SysProfileData> SysProfileDataCollectionBySysUser {
			get;
			set;
		}

		public IEnumerable<SysRecentEntity> SysRecentEntityCollectionBySysUser {
			get;
			set;
		}

		public IEnumerable<SysRegistrationData> SysRegistrationDataCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SysRepositoryUser> SysRepositoryUserCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SysRoleInMobWorkplace> SysRoleInMobWorkplaceCollectionBySysRole {
			get;
			set;
		}

		public IEnumerable<SysSchema> SysSchemaCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<SysSettingsValue> SysSettingsValueCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SysUserInRole> SysUserInRoleCollectionBySysRole {
			get;
			set;
		}

		public IEnumerable<SysUserInRole> SysUserInRoleCollectionBySysUser {
			get;
			set;
		}

		public IEnumerable<SysUserSession> SysUserSessionCollectionBySysUser {
			get;
			set;
		}

		public IEnumerable<VwEmployeesHierarchy> VwEmployeesHierarchyCollectionByManagerUser {
			get;
			set;
		}

		public IEnumerable<VwOAuthAppUser> VwOAuthAppUserCollectionBySysUser {
			get;
			set;
		}

		public IEnumerable<VwRemindingsCount> VwRemindingsCountCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<VwSocialSubscription> VwSocialSubscriptionCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<VwSocialUnsubscription> VwSocialUnsubscriptionCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<VwSysAdminUnit> VwSysAdminUnitCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<VwUserEmailsCount> VwUserEmailsCountCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<VwUserRemindingsCount> VwUserRemindingsCountCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<VwVisa> VwVisaCollectionByDelegatedFrom {
			get;
			set;
		}

		public IEnumerable<VwVisa> VwVisaCollectionByVisaOwner {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

