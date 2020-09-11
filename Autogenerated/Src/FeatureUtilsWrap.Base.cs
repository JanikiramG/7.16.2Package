namespace Terrasoft.Configuration
{
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: FeatureUtilsWrap

	[DefaultBinding(typeof(IFeatureUtilities))]
	public class FeatureUtilsWrap : IFeatureUtilities
	{

		#region Methods: Public

		/// <inheritdoc cref="IFeatureUtilities.GetIsFeatureEnabled(UserConnection, string)"/>
		public bool GetIsFeatureEnabled(UserConnection uc, string code) {
			return uc.GetIsFeatureEnabled(code);
		}

		#endregion

	}

	#endregion

}
