using CommunityToolkit.Mvvm.ComponentModel;
using thangbillapp.Models;
using thangbillapp.Utils;

namespace thangbillapp.ViewModels
{
    [QueryProperty(nameof(Product), Constants.NAV_PRAM_PRODUCT_NAME)]
    public partial class ProductDetailViewModel: ObservableObject
    {
        [ObservableProperty]
        Product product;

        public ProductDetailViewModel() 
        {

        }

    }
}
