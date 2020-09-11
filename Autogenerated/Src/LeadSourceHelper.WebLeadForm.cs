namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Specialized;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using HttpUtility = System.Web.HttpUtility;

	#region Class: LeadSourceHelper

	/// <summary>
	/// ##### ### ########### ###### # ######### ####.
	/// </summary>
	public class LeadSourceHelper
	{

		#region Constructors: Public

		/// <summary>
		/// ############## ##### ######### ###### <see cref="LeadSourceHelper"/>.
		/// </summary>
		/// <param name="userConnection">######### ################# ###########.</param>
		/// <param name="bpmHref">URL ########.</param>
		/// <param name="bpmRef">URL #########.</param>
		public LeadSourceHelper(UserConnection userConnection, string bpmHref, string bpmRef) {
			this.userConnection = userConnection;
			this.bpmHref = bpmHref;
			this.bpmRef = bpmRef;
			Uri uri;
			if (Uri.TryCreate(this.bpmHref, UriKind.Absolute, out uri)) {
				bpmHrefParameters = HttpUtility.ParseQueryString(uri.Query);
			} else {
				bpmHrefParameters = HttpUtility.ParseQueryString(string.Empty);
			}
		}

		#endregion

		#region Properties: Private

		private UserConnection userConnection;

		private string bpmHref;

		private string bpmRef;

		private EntityCollection _leadMedium = null;

		private EntityCollection LeadMedium {
			get {
				if (_leadMedium != null) {
					return _leadMedium;
				}
				_leadMedium = GetEntityCollection("LeadMedium");
				return _leadMedium;
			}
		}

		private EntityCollection _leadMediumCode = null;

		private EntityCollection LeadMediumCode {
			get {
				if (_leadMediumCode != null) {
					return _leadMediumCode;
				}
				_leadMediumCode = GetEntityCollection("LeadMediumCode");
				return _leadMediumCode;
			}
		}

		private EntityCollection _leadSource = null;

		private EntityCollection LeadSource {
			get {
				if (_leadSource != null) {
					return _leadSource;
				}
				_leadSource = GetEntityCollection("LeadSource");
				return _leadSource;
			}
		}

		private EntityCollection _leadSourceCode = null;

		private EntityCollection LeadSourceCode {
			get {
				if (_leadSourceCode != null) {
					return _leadSourceCode;
				}
				_leadSourceCode = GetEntityCollection("LeadSourceCode");
				return _leadSourceCode;
			}
		}

		private EntityCollection _leadSourceUrl = null;

		private EntityCollection LeadSourceUrl {
			get {
				if (_leadSourceUrl != null) {
					return _leadSourceUrl;
				}
				_leadSourceUrl = GetEntityCollection("LeadSourceUrl");
				return _leadSourceUrl;
			}
		}

		private NameValueCollection bpmHrefParameters = null;

		#endregion

		#region Properties: Public

		/// <summary>
		/// ########## ############# ######.
		/// </summary>
		public Guid ResultLeadMediumId {
			private set;
			get;
		}

		/// <summary>
		/// ########## ############# #########.
		/// </summary>
		public Guid ResultLeadSourceId {
			private set;
			get;
		}

		#endregion

		#region Methods: Private

		private EntityCollection GetEntityCollection(string entityname) {
			var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, entityname);
			esq.AddAllSchemaColumns();
			return esq.GetEntityCollection(userConnection);
		}

		private void GetMediumSourceByUtm() {
			string utmMediumValue = bpmHrefParameters["utm_medium"];
			string utmSourceValue = bpmHrefParameters["utm_source"];
			string utmCampaignValue = bpmHrefParameters["utm_campaign"];
			Guid leadMediumId = Guid.Empty;
			Guid leadSourceId = Guid.Empty;
			if (!string.IsNullOrEmpty(utmMediumValue)) {
				var leadMediumEntity = LeadMediumCode.Find("Code", utmMediumValue);
				if (leadMediumEntity != null) {
					leadMediumId = leadMediumEntity.GetTypedColumnValue<Guid>("LeadMediumId");
				}
			}
			if (!string.IsNullOrEmpty(utmSourceValue) || !string.IsNullOrEmpty(utmCampaignValue)) {
				var searchValue = !string.IsNullOrEmpty(utmSourceValue) ? utmSourceValue : utmCampaignValue;
				var LeadSourceCodeEntity = LeadSourceCode.Find("Code", searchValue);
				if (LeadSourceCodeEntity != null) {
					leadSourceId = LeadSourceCodeEntity.GetTypedColumnValue<Guid>("LeadSourceId");
					if (leadMediumId == Guid.Empty) {
						var leadSourceEntity = LeadSource.Find("Id", leadSourceId);
						if (leadSourceEntity != null) {
							leadMediumId = leadSourceEntity.GetTypedColumnValue<Guid>("LeadMediumId");
						}
					}
				}
			}
			ResultLeadMediumId = leadMediumId;
			ResultLeadSourceId = leadSourceId;
		}

		private void GetMediumSourceBySearchAd() {
			string gclid = bpmHrefParameters["gclid"];
			if (!string.IsNullOrEmpty(gclid)) {
				ResultLeadMediumId = LeadMediumConsts.LeadMediumSearchAdId;
				ResultLeadSourceId = LeadSourceConsts.LeadSourceGoogleAdWordsId;
			}
			string yclid = bpmHrefParameters["yclid"];
			if (!string.IsNullOrEmpty(yclid)) {
				ResultLeadMediumId = LeadMediumConsts.LeadMediumSearchAdId;
				ResultLeadSourceId = LeadSourceConsts.LeadSourcekYandexDirectId;
			}
		}

		private void GetMediumSourceByRef() {
			Entity leadSourceUrlEntity = null;
			Entity subDomainLeadSourceUrlEntity = null;
			foreach (Entity item in LeadSourceUrl) {
				string urlLookupValue = item.GetTypedColumnValue<string>("URL");
				string dotUrlLookupValue = string.Format(".{0}", urlLookupValue);
				if (bpmRef.Equals(urlLookupValue, StringComparison.OrdinalIgnoreCase)) {
					leadSourceUrlEntity = item;
				}
				if (bpmRef.EndsWith(dotUrlLookupValue, StringComparison.OrdinalIgnoreCase)) {
					subDomainLeadSourceUrlEntity = item;
				}
			}
			leadSourceUrlEntity = leadSourceUrlEntity ?? subDomainLeadSourceUrlEntity;
			if (leadSourceUrlEntity == null) {
				if (ResultLeadMediumId == Guid.Empty) {
					ResultLeadMediumId = LeadMediumConsts.LeadMediumReferrerTrafficId;
				}
				ResultLeadSourceId = LeadSourceConsts.LeadSourceOtherId;
				return;
			}
			ResultLeadSourceId = leadSourceUrlEntity.GetTypedColumnValue<Guid>("LeadSourceId");
			var leadSourceEntity = LeadSource.Find("Id", leadSourceUrlEntity.GetTypedColumnValue<Guid>("LeadSourceId"));
			if (leadSourceEntity != null) {
				ResultLeadSourceId = leadSourceEntity.GetTypedColumnValue<Guid>("Id");
				if (ResultLeadMediumId == Guid.Empty) {
					ResultLeadMediumId = leadSourceEntity.GetTypedColumnValue<Guid>("LeadMediumId");
				}
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// ######### ########### ###### # #########.
		/// </summary>
		public void ComputeMediumAndSource() {
			if (string.IsNullOrEmpty(bpmHref) && string.IsNullOrEmpty(bpmRef)) {
				return;
			}
			GetMediumSourceByUtm();
			if (ResultLeadMediumId != Guid.Empty && ResultLeadSourceId != Guid.Empty) {
				return;
			}
			GetMediumSourceBySearchAd();
			if (ResultLeadMediumId != Guid.Empty && ResultLeadSourceId != Guid.Empty) {
				return;
			}
			if (ResultLeadMediumId != Guid.Empty && ResultLeadSourceId == Guid.Empty) {
				ResultLeadSourceId = LeadSourceConsts.LeadSourceOtherId;
				return;
			}
			if (ResultLeadMediumId == Guid.Empty && ResultLeadSourceId == Guid.Empty && string.IsNullOrEmpty(bpmRef)) {
				ResultLeadMediumId = LeadMediumConsts.LeadMediumDirectTrafficId;
				return;
			}
			GetMediumSourceByRef();
		}

		#endregion
	}

	#endregion

}
