namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.ForecastV2;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: EntityInForecastCell_CoreForecastEventsProcess

	public partial class EntityInForecastCell_CoreForecastEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual Guid CreateForecastRow() {
			var repository = ClassFactory.Get<IForecastRowRepository>();
			repository.UserConnection = UserConnection;
			return repository.Create();
		}

		public virtual bool IsEmptyRow() {
			return Entity.GetTypedColumnValue<Guid>("RowId").IsEmpty();
		}

		public virtual void SetForecastRow() {
			if (Entity.StoringState == StoringObjectState.New && IsEmptyRow()) {
				var rowId = CreateForecastRow();
				Entity.SetColumnValue("RowId", rowId);
			}
		}

		#endregion

	}

	#endregion

}

