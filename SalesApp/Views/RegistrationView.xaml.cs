namespace SalesApp.Views;

public partial class RegistrationView : ContentPage
{
    public RegistrationView(RegistrationViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}