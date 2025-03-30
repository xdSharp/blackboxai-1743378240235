using SalesApp.ViewModels;

namespace SalesApp.Views;

public partial class LoginView : ContentPage
{
    public LoginView(LoginViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}