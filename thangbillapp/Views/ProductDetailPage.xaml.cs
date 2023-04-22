using thangbillapp.ViewModels;

namespace thangbillapp.Views;

public partial class ProductDetailPage : ContentPage
{
	public ProductDetailPage(ProductDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}