namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;

	#region Class: LandingContactQueryProvider

	/// <summary>
	/// Provides Query models to the specified schemas.
	/// </summary>
	public static class LandingContactQueryProvider
	{

		#region Fields: Private

		private static readonly object _lockObject = new object();

		private static Dictionary<string, ILandingContactQueryBuilder> _builders;

		#endregion

		#region Methods: Private

		private static IEnumerable<Type> GetTypesFromAssembly(Assembly workspaceAssembly, Type baseInterface) {
			return workspaceAssembly
				.GetTypes()
				.Where(t => {
					bool isBaseTypeCorrect = t.BaseType != null && t.BaseType.IsGenericType
						&& t.BaseType.GetGenericTypeDefinition() == typeof(LandingContactQueryBuilder<>);
					bool isTypeCorrect = t.IsClass && !t.IsAbstract && !t.IsGenericType && t.IsSealed;
					bool hasDefaultConstructor = t.GetConstructor(Type.EmptyTypes) != null;
					return isBaseTypeCorrect && isTypeCorrect && hasDefaultConstructor;
				});
		}

		private static void InitBuilders(Assembly assembly) {
			if (_builders != null) {
				return;
			}
			lock (_lockObject) {
				if (_builders != null) {
					return;
				}
				var tempBuilders = new Dictionary<string, ILandingContactQueryBuilder>();
				var builderTypes = GetTypesFromAssembly(assembly, typeof(ILandingContactQueryBuilder));
				foreach (Type buildertype in builderTypes) {
					var genericArgument = buildertype.BaseType.GetGenericArguments().FirstOrDefault();
					var instance = Activator.CreateInstance(buildertype) as ILandingContactQueryBuilder;
					tempBuilders.Add(genericArgument.Name, instance);
				}
				_builders = tempBuilders;
			}
		}

		private static Dictionary<string, ILandingContactQueryBuilder> GetAllBuilders(Assembly assembly) {
			InitBuilders(assembly);
			return _builders;
		}

		private static string GetSchemaNameByLanding(Guid landingId, UserConnection userConnection) {
			var schemaUidSelect = new Select(userConnection)
				.Column("LT", "SchemaUidId")
				.From("GeneratedWebForm").As("GWF")
				.InnerJoin("LandingType").As("LT")
					.On("LT", "Id").IsEqual("GWF", "TypeId")
				.Where("GWF", "Id").IsEqual(Column.Parameter(landingId)) as Select;
			schemaUidSelect.SpecifyNoLockHints();
			schemaUidSelect.IsCacheEnabled = true;
			var schemaUid = schemaUidSelect.ExecuteScalar<Guid>();
			var schema = userConnection.EntitySchemaManager.GetItems().FirstOrDefault(x => x.UId == schemaUid);
			return schema?.Name ?? string.Empty;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Calls a specific builder to get the <see cref="ContactSelectModel"/> of a produced query.
		/// </summary>
		/// <param name="webFormId">The unique identifier of landing.</param>
		/// <param name="userConnection">Instance of the <see cref="UserConnection"/> type.</param>
		/// <returns>An instance of <see cref="ContactSelectModel"/>.</returns>
		/// <exception cref="ArgumentException">In case of schema absence.</exception>
		public static ContactSelectModel GetSelectModel(Guid webFormId, UserConnection userConnection) {
			ILandingContactQueryBuilder instance;
			var schemaName = GetSchemaNameByLanding(webFormId, userConnection);
			var buildersList = GetAllBuilders(userConnection.Workspace.WorkspaceAssembly);
			if (buildersList.TryGetValue(schemaName, out instance)) {
				var select = instance.GetRelatedContactsSelect(userConnection, webFormId);
				return new ContactSelectModel {
					ContactSelect = select,
					ContactIdColumnName = instance.ContactIdColumnName
				};
			}
			throw new ArgumentException("Unknown schema name {0}", schemaName);
		}

		#endregion

	}

	#endregion

}
