using TestTabbedApp.ViewModels;

namespace TestTabbedApp.Views;

public partial class FirstTabPage : ContentPage
{
	public FirstTabPage(RootTabsViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
    }
}