using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thangbillapp.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? ProductName { get; set; }

        public int ProducType { get; set; }

        public string? ProductDescription { get; set; }

        public double? Price { get; set; }

        public int Quantity { get; set; }

        public string? Weight { get; set; }

        public string? Image { get; set; }
    }
}
