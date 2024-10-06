using System;
using System.Collections.Generic;

#nullable disable

namespace Turboaz.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBrandId { get; set; }
        public string ProductYear { get; set; }
        public int? ProductPrice { get; set; }
        public int? ProductMileage { get; set; }
        public string ProductFuelType { get; set; }
        public string ProductTransmission { get; set; }
        public string ProductColor { get; set; }
    }
}
