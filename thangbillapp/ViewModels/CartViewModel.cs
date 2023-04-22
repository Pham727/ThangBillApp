using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using thangbillapp.Models;

namespace thangbillapp.ViewModels
{
    public partial class CartViewModel: ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Product> products;

        public CartViewModel()
        {
            createDataProducts();
        }

        public void createDataProducts()
        {
            var bananas = new Product { ProductName = "Ogranic Bananas", Image = "bananas.jpg", Price = 5.55, Weight = "1kg, Priceg ", ProductDescription = "Apples are nutritious. Apples may be good for weight loss. apples may be good for your heart. As part of a healtful and varied diet." };
            var oranges = new Product { ProductName = "Orange sugar", Image = "cam.jpg", Price = 5.55, Weight = "1kg, Priceg ", ProductDescription = "Apples are nutritious. Apples may be good for weight loss. apples may be good for your heart. As part of a healtful and varied diet." };
            var watermelons = new Product { ProductName = "seedless watermelon", Image = "dua_hau.jpg", Price = 5.55, Weight = "1kg, Priceg ", ProductDescription = "Apples are nutritious. Apples may be good for weight loss. apples may be good for your heart. As part of a healtful and varied diet." };
            var apples = new Product { ProductName = "Red Apples", Image = "tao.jpg", Price = 5.55, Weight = "1kg, Priceg ", ProductDescription = "Apples are nutritious. Apples may be good for weight loss. apples may be good for your heart. As part of a healtful and varied diet." };
            var pears = new Product { ProductName = "stone pear", Image = "le.jpg", Price = 5.55, Weight = "1kg, Priceg ", ProductDescription = "Apples are nutritious. Apples may be good for weight loss. apples may be good for your heart. As part of a healtful and varied diet." };
            Products = new ObservableCollection<Product> { bananas, oranges, watermelons, apples, pears };
        }
    }
}
