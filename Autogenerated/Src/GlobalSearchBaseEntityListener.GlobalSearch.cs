namespace Terrasoft.Configuration.GlobalSearch
{
	using System;
	using System.Linq;
	using global::Common.Logging;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;
	using Terrasoft.Core.Factories;
	using Terrasoft.GlobalSearch.Indexing;

	#region Class: GlobalSearchBaseEntityListener

	/// <summary>
	/// Listener for 'BaseEntity' entity events.
	/// </summary>
	/// <seealso cref="Terrasoft.Core.Entities.Events.BaseEntityEventListener"/>
	[EntityEventListener(SchemaName = "BaseEntity")]
	public class GlobalSearchBaseEntityListener : BaseEntityEventListener
	{
		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("GlobalSearch");

		#endregion

		#region Properties: Private

		private IndexerFactory _indexerFactory;
		private IndexerFactory IndexerFactory =>
			_indexerFactory ??
			(_indexerFactory = ClassFactory.Get<IndexerFactory>());

		#endregion

		#region Methods: Public

		/// <summary>
		/// Handles entity inserted event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">
		/// The <see cref="T:Terrasoft.Core.Entities.EntityAfterEventArgs"/> instance containing the
		/// event data.
		/// </param>
		public override void OnInserted(object sender, EntityAfterEventArgs e) {
			base.OnInserted(sender, e);
			try {
				var entity = (Entity) sender;
				var indexer = IndexerFactory.GetForInsert(entity);
				indexer.IndexEntity(entity, IndexingOperationType.Index);
			} catch (Exception exception) {
				_log.Error("Error during indexing after entity inserted", exception);
			}
		}

		/// <summary>
		/// Handles entity Deleted event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">
		/// The <see cref="T:Terrasoft.Core.Entities.EntityAfterEventArgs"/> instance containing the
		/// event data.
		/// </param>
		public override void OnDeleted(object sender, EntityAfterEventArgs e) {
			base.OnDeleted(sender, e);
			try {
				var entity = (Entity) sender;
				var indexer = IndexerFactory.GetForDelete();
				indexer.IndexEntity(entity, IndexingOperationType.Delete);
			} catch (Exception exception) {
				_log.Error("Error during indexing after entity deleted", exception);
			}
		}

		/// <summary>
		/// Handles entity updated event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">
		/// The <see cref="T:Terrasoft.Core.Entities.EntityAfterEventArgs"/> instance containing the
		/// event data.
		/// </param>
		public override void OnUpdated(object sender, EntityAfterEventArgs e) {
			base.OnUpdated(sender, e);
			try {
				var entity = (Entity) sender;
				var indexer = IndexerFactory.GetForUpdate(entity, e);
				indexer.IndexEntity(entity, IndexingOperationType.Index);
			} catch (Exception exception) {
				_log.Error("Error during indexing after entity deleted", exception);
			}
		}

		#endregion
	}

	#endregion

}
