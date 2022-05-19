using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkatTekProject.Products.Dto
{
    public class ProductDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }

        
        public int ProductCategoryId { get; set; }
        
        public ProductStatus ProductStatus { get; set; }

        public DateTime CreationTime { get; set; }
        public int? TenantId { get; set; }
     
    }
}
