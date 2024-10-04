using TestTabbedApp.ViewModels;

namespace TestTabbedApp.Views;

public partial class ThirdTabPage : ContentPage
{
	public ThirdTabPage(RootTabsViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
    }
}