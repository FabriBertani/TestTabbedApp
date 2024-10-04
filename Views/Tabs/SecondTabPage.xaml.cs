using TestTabbedApp.ViewModels;

namespace TestTabbedApp.Views;

public partial class SecondTabPage : ContentPage
{
	public SecondTabPage(RootTabsViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
    }
}