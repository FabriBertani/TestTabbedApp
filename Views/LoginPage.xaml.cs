using TestTabbedApp.ViewModels;

namespace TestTabbedApp.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}