namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Web.Common;

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class RelationshipDiagramService : BaseService
	{

		#region Methods: Private

		/// <summary>
		/// ########## ######### ### ########## ############## #######.
		/// </summary>
		/// <param name="select">######</param>
		/// <param name="hierarchicalSelectType">### ############## #######.</param>
		/// <returns>######### ### ########## ############## #######.</returns>
		private HierarchicalSelectOptions GetHierarchicalSelectOptions(Select select,
				HierarchicalSelectType hierarchicalSelectType) {
			var hierarhicalOptions = new HierarchicalSelectOptions {
				PrimaryColumnName = "Id",
				ParentColumnName = "Parent.Id",
				SelectType = hierarchicalSelectType,
				IncludeLevelColumn = true
			};
			QueryCondition startingCondition = hierarhicalOptions.StartingPrimaryColumnCondition;
			startingCondition.LeftExpression = new QueryColumnExpression("Id");
			startingCondition.IsEqual(select.Parameters.GetByName("StartingAccountId"));
			return hierarhicalOptions;
		}


		/// <summary>
		/// Builds a select query to receive accounts for relationship diagram.
		/// </summary>
		/// <param name="accountId">Account unique identifier.</param>
		/// <param name="additionalColumnNames">List of names of additional columns to receive.</param>
		/// <param name="useAdminRights">Flag indicating that administration rights should be applied to the
		/// query.</param>
		private Select GetAccountSelect(Guid accountId, IEnumerable<string> additionalColumnNames, bool useAdminRights) {
			var accountTableESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Account");
			accountTableESQ.UseAdminRights = useAdminRights;
			accountTableESQ.AddColumn("Id");
			accountTableESQ.AddColumn("Parent.Id");
			if (additionalColumnNames != null) {
				foreach (string columnName in additionalColumnNames) {
					accountTableESQ.AddColumn(columnName);
				}
			}
			Select accountSelect = accountTableESQ.GetSelectQuery(UserConnection);
			accountSelect.Parameters.Add(new QueryParameter("StartingAccountId", accountId, "Guid"));
			accountSelect.InitializeParameters();
			return accountSelect;
		}

		/// <summary>
		/// ######### ########## ############## ###### ######## ############# ########### # ###### #### #######.
		/// </summary>
		/// <param name="accountId">Id ###########.</param>
		/// <returns>########## ############# ###########.</returns>
		private Guid GetRootParentAccount(Guid accountId) {
			Guid result = Guid.Empty;
			int levelMax = Int32.MinValue;
			Select accountSelect = GetAccountSelect(accountId, null, useAdminRights: true);
			HierarchicalSelectOptions hierarhicalOptions =
				GetHierarchicalSelectOptions(accountSelect, HierarchicalSelectType.Parents);
			accountSelect.HierarchicalOptions = hierarhicalOptions;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = accountSelect.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						int level = reader.GetColumnValue<int>("Level");
						if (level > levelMax) {
							result = reader.GetColumnValue<Guid>("Id");
							levelMax = level;
						}
					}
				}
			}
			return result;
		}

		/// <summary>
		/// Receives all child accounts of the specified parent account. Does not consider user access rights.
		/// </summary>
		/// <param name="parentAccountId">Parent account for all accounts to receive.</param>
		/// <param name="additionalColumnNames">List of names of additional columns to receive.</param>
		/// <returns>List of child accounts.</returns>
		private List<AccountInfo> GetAllChildAccounts(Guid parentAccountId, List<string> additionalColumnNames) {
			var resultList = new List<AccountInfo>();
			additionalColumnNames = additionalColumnNames ?? new List<string>();
			additionalColumnNames.Add("Name");
			additionalColumnNames.Add("Type.Name");
			Select accountSelect = GetAccountSelect(parentAccountId, additionalColumnNames, useAdminRights: false);
			HierarchicalSelectOptions hierarhicalOptions =
				GetHierarchicalSelectOptions(accountSelect, HierarchicalSelectType.Children);
			accountSelect.HierarchicalOptions = hierarhicalOptions;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = accountSelect.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						Guid id = reader.GetColumnValue<Guid>("Id");
						string name = reader.GetColumnValue<string>("Name");
						string accountType = reader.GetColumnValue<string>("Type.Name");
						int level = reader.GetColumnValue<int>("Level");
						Guid parentId = reader.GetColumnValue<Guid>("Parent.Id");
						var additionalColumnValues = additionalColumnNames.ToDictionary(columnName => columnName,
							columnName => reader.GetColumnValue(columnName));
						resultList.Add(new AccountInfo {
							Id = id,
							Name = name,
							ParentId = parentId,
							AccountType = accountType,
							Level = level,
							AdditionalColumnValues = additionalColumnValues
						});
					}
				}
			}
			return resultList;
		}

		/// <summary>
		/// Returns only those accounts of specified that are accessible by current user considering rights by record.
		/// </summary>
		/// <param name="accounts">List of accounts to filter.</param>
		private List<AccountInfo> FilterAccountsByUserRights(List<AccountInfo> accounts) {
			if (accounts.Count == 0) {
				return new List<AccountInfo>();
			}
			var accountESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Account");
			accountESQ.PrimaryQueryColumn.IsVisible = true;
			accountESQ.UseAdminRights = true;
			accountESQ.Filters.Add(accountESQ.CreateFilterWithParameters(FilterComparisonType.Equal,
				accountESQ.PrimaryQueryColumn.Name, accounts.Select(account => account.Id).Cast<object>().ToArray()));
			Guid[] accessibleAccountIds = accountESQ.GetEntityCollection(UserConnection)
				.Select(entity => entity.PrimaryColumnValue).ToArray();
			return accounts.Where(account => accessibleAccountIds.Contains(account.Id)).ToList();
		}

		/// <summary>
		/// Returns only those accounts of specified that are related to account specified by
		/// <paramref name="mainAccountId"/> and accessible by current user considering rights by record.
		/// </summary>
		/// <param name="mainAccountId">Unique identifier of the account.</param>
		/// <param name="accounts">List of accounts to filter.</param>
		private List<AccountInfo> FilterRelatedAccountsByUserRights(Guid mainAccountId, List<AccountInfo> accounts) {
			List<AccountInfo> accessibleAccounts = this.FilterAccountsByUserRights(accounts);
			var result = new List<AccountInfo>(accessibleAccounts.Count);
			AccountInfo mainAccount = accessibleAccounts.FirstOrDefault(account => account.Id == mainAccountId);
			if (mainAccount == null) {
				return result;
			}
			AccountInfo GetAccessibleRootParent(AccountInfo account) {
				AccountInfo parent = account.ParentId.Equals(Guid.Empty)
					? null
					: accessibleAccounts.FirstOrDefault(acc => acc.Id == account.ParentId);
				return parent == null
					? account
					: GetAccessibleRootParent(parent);
			}
			AccountInfo rootParentAccount = GetAccessibleRootParent(mainAccount);
			void TryAddAccountWithChildren(AccountInfo accountToAdd) {
				result.Add(accountToAdd);
				IEnumerable<AccountInfo> childAccounts =
					accessibleAccounts.Where(account => account.ParentId == accountToAdd.Id);
				foreach (AccountInfo childAccount in childAccounts) {
					TryAddAccountWithChildren(childAccount);
				}
			}
			TryAddAccountWithChildren(rootParentAccount);
			return result;
		}

		/// <summary>
		/// Receives all accounts in relationship tree for the specified account considering user access rights.
		/// </summary>
		/// <param name="accountId">Account unique identifier.</param>
		/// <param name="rootParentAccountId">Unique identifier of maximum level parent account.</param>
		/// <param name="additionalColumnNames">List of names of additional columns to receive.</param>
		/// <returns>List of accounts in relationship tree.</returns>
		private List<AccountInfo> GetRelationshipDiagramAccounts(Guid accountId, Guid rootParentAccountId,
				List<string> additionalColumnNames) {
			List<AccountInfo> resultList = this.GetAllChildAccounts(rootParentAccountId, additionalColumnNames);
			string readByAdminOperation =
				AdminOperations.FromEntitySchemaRecordRightOperation(EntitySchemaRecordRightOperation.Read);
			if (!UserConnection.DBSecurityEngine.GetCanExecuteOperation(readByAdminOperation)) {
				resultList = FilterRelatedAccountsByUserRights(accountId, resultList);
			}
			return resultList;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// ######### ############### ############.
		/// </summary>
		/// <param name="accountId">########## ############# ###########.</param>
		/// <param name="additionalColumnNames">###### ######## ############## #######.</param>
		/// <returns>###### ############.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
		ResponseFormat = WebMessageFormat.Json)]
		public RelationshipDiagramServiceResponse GetRelationshipDiagramInfo(Guid accountId,
				List<string> additionalColumnNames) {
			var response = new RelationshipDiagramServiceResponse();
			try {
				Guid rootParentAccountId = GetRootParentAccount(accountId);
				response.ParentId = rootParentAccountId;
				response.Accounts = rootParentAccountId.Equals(Guid.Empty)
					? new List<AccountInfo>()
					: GetRelationshipDiagramAccounts(accountId, rootParentAccountId, additionalColumnNames);
			} catch (Exception e) {
				response.Exception = e;
			}
			return response;
		}

		#endregion

		#region Class: Public

		[DataContract]
		public class RelationshipDiagramServiceResponse : ConfigurationServiceResponse
		{

			#region Properties: Public

			/// <summary>
			/// ###### ############.
			/// </summary>
			[DataMember(Name = "accounts")]
			public List<AccountInfo> Accounts {
				get;
				set;
			}

			/// <summary>
			/// ############ ########## ######## ######.
			/// </summary>
			[DataMember(Name = "parentId")]
			public Guid ParentId {
				get;
				set;
			}

			#endregion

		}

		[DataContract]
		public class AccountInfo
		{

			#region Properties: Public

			/// <summary>
			/// ########## ############# ###########.
			/// </summary>
			[DataMember(Name = "id")]
			public Guid Id {
				get;
				set;
			}

			/// <summary>
			/// ######## ###########.
			/// </summary>
			[DataMember(Name = "name")]
			public string Name {
				get;
				set;
			}

			/// <summary>
			/// ########## ############# ############# ###########.
			/// </summary>
			[DataMember(Name = "parentId")]
			public Guid ParentId {
				get;
				set;
			}

			/// <summary>
			/// ### ###########.
			/// </summary>
			[DataMember(Name = "accountType")]
			public string AccountType {
				get;
				set;
			}

			/// <summary>
			/// ####### # ########.
			/// </summary>
			[DataMember(Name = "level")]
			public int Level {
				get;
				set;
			}

			/// <summary>
			/// ######## ############# ########### #######.
			/// </summary>
			[DataMember(Name = "additionalColumnValues")]
			public Dictionary<string, object> AdditionalColumnValues {
				get;
				set;
			}

			#endregion

		}

		#endregion

	}
}

