namespace Terrasoft.Configuration.ESN
{
	using Core;
	using Core.Factories;

	#region  Class: EsnCenterFactory

	/// <inheritdoc />
	[DefaultBinding(typeof(IEsnCenterFactory))]
	public class EsnCenterFactory : IEsnCenterFactory
	{
		#region Methods: Public

		/// <inheritdoc />
		public IEsnCenter CreateEsnCenter(UserConnection userConnection) {
			var userConnectionArgument = new ConstructorArgument("userConnection", userConnection);
			var likeRepository = ClassFactory.Get<IEsnLikeRepository>(userConnectionArgument);
			var esnMessageReader = ClassFactory.Get<IEsnMessageReader>(userConnectionArgument);
			var esnMessageRedactor = ClassFactory.Get<IEsnMessageRedactor>(userConnectionArgument);
			var esnSecurityEngine = ClassFactory.Get<IEsnSecurityEngine>(userConnectionArgument);
			return ClassFactory.Get<IEsnCenter>(
				new ConstructorArgument("esnLikeRepository", likeRepository),
				new ConstructorArgument("esnMessageReader", esnMessageReader),
				new ConstructorArgument("esnMessageRedactor", esnMessageRedactor),
				new ConstructorArgument("esnSecurityEngine", esnSecurityEngine));
		}

		#endregion
	}

	#endregion
}

