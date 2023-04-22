using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thangbillapp.Models;

namespace thangbillapp.Services
{
    public interface IProductServices
    {
        public Task<List<Product>> GetAll();
    }
}
