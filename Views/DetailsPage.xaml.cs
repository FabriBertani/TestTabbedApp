using TestTabbedApp.ViewModels;

namespace TestTabbedApp.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}