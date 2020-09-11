namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Nui.ServiceModel.Extensions;
	using Terrasoft.Web.Common;
	using CoreEntitySchema = Terrasoft.Core.Entities.EntitySchema;
	using EntityCollection = Terrasoft.Core.Entities.EntityCollection;

	#region Class: VisaDataService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class VisaDataService : BaseService
	{

		#region Methods: Private

		private VisaHelper GetVisaHelper(Guid sysAdminUnitId) {
			return ClassFactory.Get<VisaHelper>(new ConstructorArgument("sysAdminUnitId", sysAdminUnitId),
				new ConstructorArgument("userConnection", UserConnection));
		}

		#endregion

		#region Methods: Public

		[OperationContract]
		[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
		BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
		public string GetVisaEntities(Guid sysAdminUnitId, RequestOptions requestOptions) {
			var helper = GetVisaHelper(sysAdminUnitId);
			SelectQueryResponse result = helper.GetEntities(requestOptions);
			return ServiceStackTextHelper.Serialize(result);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
		BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
		public string GetVisaEntity(Guid sysAdminUnitId, Guid visaId) {
			var helper = GetVisaHelper(sysAdminUnitId);
			SelectQueryResponse result = helper.GetEntity(visaId);
			return ServiceStackTextHelper.Serialize(result);
		}

		#endregion
	}
	
	#endregion

	#region Class: VisaHelper
	
	public class VisaHelper {

		#region Fields: Private

		private UserConnection _userConnection;

		private Guid _sysAdminUnitId;

		private CoreEntitySchema _baseVisaSchema;

		private EntitySchemaQuery _baseVisaESQ;

		#endregion

		#region Constructord: Public

		public VisaHelper(Guid sysAdminUnitId, UserConnection userConnection) {
			_sysAdminUnitId = sysAdminUnitId;
			_userConnection = userConnection;
			_baseVisaSchema = GetExtendedBaseVisaEntitySchema();
			_baseVisaESQ = GetExtendedBaseVisaESQ(_baseVisaSchema);
		}

		#endregion

		#region Methods: Private

		private Select WrapSelect(Select sourceSelect) {
			EntitySchemaColumnCollection visaColumns = _baseVisaSchema.Columns;
			string alias = "InternalSelect";
			Select select = 
				new Select(_userConnection)
					.Column(alias, "Id")
					.Column(alias, "CreatedOn")
					.Column(alias, "CreatedById")
					.Column(alias, "ModifiedOn")
					.Column(alias, "ModifiedById")
					.Column(alias, "ProcessListeners")
					.Column(alias, "Objective")
					.Column(alias, "VisaOwnerId")
					.Column(alias, "IsAllowedToDelegate")
					.Column(alias, "DelegatedFromId")
					.Column(alias, "StatusId")
					.Column(alias, "SetById")
					.Column(alias, "SetDate")
					.Column(alias, "IsCanceled")
					.Column(alias, "Comment")
					.Column(alias, "VisaSchemaName")
					.Column(alias, "Title")
					.Column(alias, "VisaObjectId")
					.Column(alias, "VisaSchemaTypeId")
					.Column(alias, "VisaTypeName")
					.Column(alias, "VisaSchemaCaption")
					.Column(alias, "SchemaName")
					.Column(alias, "SourceSchemaName")
					.Column("CreatedBy", "Name").As(visaColumns.FindByName("CreatedBy").DisplayColumnValueName)
					.Column("VisaStatus", "Name").As(visaColumns.FindByName("Status").DisplayColumnValueName)
				.From(sourceSelect).As(alias)
				.LeftOuterJoin("Contact").As("CreatedBy").On("CreatedBy", "Id").IsEqual(alias, "CreatedById")
				.LeftOuterJoin("VisaStatus").On("VisaStatus", "Id").IsEqual(alias, "StatusId")
				.OrderBy(OrderDirectionStrict.Descending, alias, "ModifiedOn") as Select;
			return select;
		}

		private void ApplyOptions(ref Select select, RequestOptions requestOptions) {
			if (requestOptions.IsPageable) {
				select.Top(requestOptions.RowCount);
			}
		}

		private Dictionary<string, string> GetColumnNameMap(Select select) {
			var map = new Dictionary<string, string>();
			foreach(var column in select.Columns) {
				string columnName = column.Alias;
				if (string.IsNullOrEmpty(columnName)) {
					columnName = column.SourceColumnAlias;
				}
				map[columnName] = columnName;
			}
			map["CreatedBy"] = "CreatedBy";
			map["Status"] = "Status";
			return map;
		}

		private CoreEntitySchema GetExtendedBaseVisaEntitySchema() {
			var entitySchemaManager = _userConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var baseVisaEntitySchema = entitySchemaManager.GetInstanceByName("BaseVisa");
			CoreEntitySchema baseVisaSchema = new CoreEntitySchema(baseVisaEntitySchema, false);
			baseVisaSchema.AddColumn("LongText", "Title");
			baseVisaSchema.AddColumn("LongText", "VisaSchemaName");
			baseVisaSchema.AddColumn("Guid", "VisaObjectId");
			baseVisaSchema.AddColumn("Guid", "VisaSchemaTypeId");
			baseVisaSchema.AddColumn("LongText", "VisaTypeName");
			baseVisaSchema.AddColumn("LongText", "VisaSchemaCaption");
			baseVisaSchema.AddColumn("LongText", "SchemaName");
			baseVisaSchema.AddColumn("LongText", "SourceSchemaName");
			return baseVisaSchema;
		}

		private EntitySchemaQuery GetExtendedBaseVisaESQ(CoreEntitySchema schema) {
			EntitySchemaQuery entitySchemaQuery = new EntitySchemaQuery(schema);
			entitySchemaQuery.RootSchema.IsVirtual = false;
			entitySchemaQuery.AddAllSchemaColumns();
			return entitySchemaQuery;
		}

		private SelectQueryResponse GetVisaData(Select entitiesSelect) {
			Dictionary<string, string> serverToClientColumnNameMap = GetColumnNameMap(entitiesSelect);
			var collection = new EntityCollection(_userConnection, _baseVisaSchema);
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = entitiesSelect.ExecuteReader(dbExecutor)) {
					collection.Load(dataReader);
				}
			}
			var convertedEntities = QueryExtension.GetEntityCollection(collection, serverToClientColumnNameMap);
			Dictionary<string, object> config = QueryExtension.GetColumnConfig(_baseVisaESQ, serverToClientColumnNameMap);
			SelectQueryResponse response = new SelectQueryResponse {
				Rows = convertedEntities,
				RowsAffected = convertedEntities.Count,
				RowConfig = config
			};
			return response;
		}

		private static SelectQueryResponse GetEmptyResponse() {
			return new SelectQueryResponse {
				Rows = null,
				RowsAffected = 0,
				RowConfig = null
			};
		}

		#endregion

		#region Methods: Protected

		protected virtual List<Select> GetSelectsFromProviders() {
			Dictionary<string, object> parameters = new Dictionary<string, object> {
				{ "sysAdminUnitId", _sysAdminUnitId },
				{ "userConnection", _userConnection }
			};
			NotificationUtilities notificationUtilities = new NotificationUtilities();
			List<string> classNames = notificationUtilities
				.GetNotificationProviderClassNames(NotificationProviderType.Visa, _userConnection);
			List<Select> selectsFromProviders = new List<Select>();
			if (classNames.Count > 0) {
				object[] objectParams = { parameters };
				foreach (string className in classNames) {
					var classInstance = notificationUtilities.GetClassInstance(className, objectParams);
					Select providerSelect = ((INotificationProvider)classInstance).GetEntitiesSelect();
					if (providerSelect != null) {
						selectsFromProviders.Add(providerSelect);
					}
				}				
			}
			return selectsFromProviders;
		}

		protected virtual Select GetMainSelect(Guid? visaId) {
			Select mainSelect = null;
			List<Select> selectsFromProviders = GetSelectsFromProviders();
			foreach (Select providerSelect in selectsFromProviders) {
				string sourceSchemaName = providerSelect.SourceExpression.SchemaName;
				if (visaId != null) {
					providerSelect.And(sourceSchemaName, "Id").IsEqual(Column.Parameter(visaId));
				}
				QueryColumnExpression expression = Column.Parameter(sourceSchemaName);
				expression.Alias = "SourceSchemaName";
				providerSelect.Column(expression);
				mainSelect = mainSelect == null
					? providerSelect
					: mainSelect.UnionAll(providerSelect) as Select;
			}
			return mainSelect;
		}

		#endregion

		#region Methods: Public

		public SelectQueryResponse GetEntities(RequestOptions requestOptions) {
			Select mainSelect = GetMainSelect(null);
			if (mainSelect == null) {
				return GetEmptyResponse();
			}
			Select entitiesSelect = WrapSelect(mainSelect);
			ApplyOptions(ref entitiesSelect, requestOptions);
			return GetVisaData(entitiesSelect);
		}

		public SelectQueryResponse GetEntity(Guid visaId) {
			Select mainSelect = GetMainSelect(visaId);
			if (mainSelect == null) {
				return GetEmptyResponse();
			}
			Select entitiesSelect = WrapSelect(mainSelect);
			return GetVisaData(entitiesSelect);
		}

		#endregion
	}
	
	#endregion
	
	#region Class: RequestOptions
	
	[DataContract, Serializable]
	public class RequestOptions {

		#region Properties: Public

		[DataMember(Name = "isPageable")]
		public bool IsPageable {
			get; set;
		}

		[DataMember(Name = "rowCount")]
		public int RowCount {
			get; set;
		}

		#endregion
	}
	
	#endregion
	
	#region Class: ConditionalValues
	
	[DataContract, Serializable]
	public class ConditionalValues {
		
		#region Properties: Public

		[DataMember(Name = "columnName")]
		public string ColumnName {
			get; set;
		}

		[DataMember(Name = "value")]
		public object Value {
			get; set;
		}

		[DataMember(Name = "valueType")]
		public int ValueType {
			get; set;
		}
		
		#endregion
	}
	
	#endregion

}

