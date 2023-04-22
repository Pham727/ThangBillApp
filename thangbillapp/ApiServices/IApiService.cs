using Firebase.Auth;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thangbillapp.Models;

namespace thangbillapp.ApiServices
{
    public interface IApiService
    {
        [Get("/Product")]
        Task<List<Product>> GetAllProduct();
    }
}
