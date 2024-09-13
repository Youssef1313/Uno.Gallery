using System.Reflection;

namespace Uno.Gallery.Views.GeneralPages
{
	public sealed partial class OverviewPageHeader : UserControl
	{
		public OverviewPageHeader()
		{
			this.InitializeComponent();
			galleryText.Text = galleryText.Text.Replace("$0$", typeof(UserControl).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "Unknown");
		}
	}
}
