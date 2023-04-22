using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using thangbillapp.Models;
using thangbillapp.Services;
using thangbillapp.Utils;
using thangbillapp.Views;

namespace thangbillapp.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        List<Product> exclusiveProducts;

        private IProductServices productServices;

        public HomeViewModel(IProductServices productServices) {
            this.productServices = productServices;           
        }

        public async Task CreateDataExclusiveProducts()
        {
            var products = await productServices.GetAll();
            //var listProducts = await productServices.GetAll();
            //var bananas = new Product { ProductName = "Ogranic Bananas", Image = "bananas.jpg", Price = 4.99, Weight = "1kg, Priceg ", ProductDescription = "Apples are nutritious. Apples may be good for weight loss. apples may be good for your heart. As part of a healtful and varied diet." };
            //var oranges = new Product { ProductName = "Orange sugar", Image = "cam.jpg", Price = 4.99, Weight = "1kg, Priceg ", ProductDescription = "Apples are nutritious. Apples may be good for weight loss. apples may be good for your heart. As part of a healtful and varied diet." };
            //var watermelons = new Product { ProductName = "seedless watermelon", Image = "dua_hau.jpg", Price = 4.99, Weight = "1kg, Priceg ", ProductDescription = "Apples are nutritious. Apples may be good for weight loss. apples may be good for your heart. As part of a healtful and varied diet." };
            //var apples = new Product { ProductName = "Red Apples", Image = "tao.jpg", Price = 4.99, Weight = "1kg, Priceg ", ProductDescription = "Apples are nutritious. Apples may be good for weight loss. apples may be good for your heart. As part of a healtful and varied diet." };
            //var pears = new Product { ProductName = "stone pear", Image = "le.jpg", Price = 4.99, Weight = "1kg, Priceg ", ProductDescription = "Apples are nutritious. Apples may be good for weight loss. apples may be good for your heart. As part of a healtful and varied diet." };
            //ExclusiveProducts = new ObservableCollection<Product> { bananas, oranges,watermelons, apples, pears };
            ExclusiveProducts = products;
        }

        [RelayCommand]
        public async Task ProductDetail(Product product)
        {
            var navigationParameter = new Dictionary<string, object> { 
                { Constants.NAV_PRAM_PRODUCT_NAME, product } 
            };
            await Shell.Current.GoToAsync(nameof(ProductDetailPage), navigationParameter);
        }

        [RelayCommand]
        public async void AddProduct(Product product)
        {
           await CreateDataExclusiveProducts();
        }
    }
}
