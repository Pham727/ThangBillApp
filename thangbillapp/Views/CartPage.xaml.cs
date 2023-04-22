using thangbillapp.ViewModels;

namespace thangbillapp.Views;

public partial class CartPage : ContentPage
{
	public CartPage()
	{
		InitializeComponent();
		BindingContext =new CartViewModel();
	}
}