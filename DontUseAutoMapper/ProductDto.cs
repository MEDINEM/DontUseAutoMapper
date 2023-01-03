using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontUseAutoMapper
{
    public class ProductDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }

        public static explicit operator ProductDto(Product product)
        {
            return new ProductDto
            {
                Name = product.ProductName,
                Description = product.ProductDescription,
                Price = product.Price + product.Price * 100 / product.VatPercentage
            };
        }
    }
}
