using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thangbillapp.ApiServices;
using thangbillapp.Models;

namespace thangbillapp.Services
{
    public class ProductServices: IProductServices
    {
        private IApiService apiService;

        public ProductServices(IApiService apiService) {

            this.apiService = apiService;
        }
        public async Task<List<Product>> GetAll()
        {
            List<Product> products = null;
            try
            {
                var result = await apiService.GetAllProduct();

                int i = 20;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return products;
        }
    }
}
