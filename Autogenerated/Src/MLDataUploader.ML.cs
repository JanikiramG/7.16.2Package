namespace Terrasoft.Configuration.ML
{
	using System;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;

	#region Interface: IMLDataUploader

	/// <summary>
	/// Uploads data to machine learning service.
	/// </summary>
	public interface IMLDataUploader
	{

		#region Methods: Public

		/// <summary>
		/// Uploads the data to machine learning service.
		/// </summary>
		/// <param name="select"><see cref="Terrasoft.Core.DB.Select"/> query, that returns the data for training.
		/// </param>
		/// <returns>Number of uploaded records.</returns>
		int Upload(Select select);

		#endregion

	}

	#endregion

	#region Class: MLDataUploader

	/// <summary>
	/// Provides a base class for implementations of the <see cref="IMLDataUploader"/> interface.
	/// </summary>
	/// <seealso cref="Terrasoft.Configuration.ML.IMLDataUploader" />
	[DefaultBinding(typeof(IMLDataUploader))]
	public class MLDataUploader : IMLDataUploader
	{

		#region Fields: Private

		private readonly IMLDataLoader _mlDataLoader;
		private readonly IMLServiceProxy _mlServiceProxy;
		private readonly Guid _sessionId;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="MLDataUploader"/> class.
		/// </summary>
		/// <param name="mlServiceProxy">The machine learning service proxy.</param>
		/// <param name="sessionId">The training session identifier.</param>
		/// <param name="loader">The loader.</param>
		public MLDataUploader(IMLServiceProxy mlServiceProxy, Guid sessionId, IMLDataLoader loader) {
			_mlServiceProxy = mlServiceProxy;
			_sessionId = sessionId;
			_mlDataLoader = loader;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Uploads the chunk data.
		/// </summary>
		/// <param name="data">The data to be uploaded.</param>
		protected virtual void UploadChunkData(string data) {
			_mlServiceProxy.UploadData(data, _sessionId);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Uploads the data to machine learning service.
		/// </summary>
		/// <param name="select"><see cref="Terrasoft.Core.DB.Select" /> query, that returns the data for training.
		/// </param>
		/// <returns>
		/// Number of uploaded records.
		/// </returns>
		public int Upload(Select select) {
			int rowCount = _mlDataLoader.LoadData(select, UploadChunkData);
			return rowCount;
		}

		#endregion

	}

	#endregion

}

