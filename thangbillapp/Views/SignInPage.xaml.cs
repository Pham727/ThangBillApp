using thangbillapp.ViewModels;

namespace thangbillapp.Views;

public partial class SignInPage : ContentPage
{
	public SignInPage(SignInViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}