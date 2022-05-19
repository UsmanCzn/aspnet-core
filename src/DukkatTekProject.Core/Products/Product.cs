using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using DukkatTekProject.Products.ProductCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkatTekProject.Products
{
    [Table("Products")]
    public class Product : Entity<long>, IHasCreationTime, IMayHaveTenant, IHasDeletionTime
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }

        [ForeignKey("ProductCategories")]
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public ProductStatus ProductStatus { get; set; }

        public DateTime CreationTime { get ; set ; }
        public int? TenantId { get ; set ; }
        public DateTime? DeletionTime { get; set ; }
        public bool IsDeleted { get; set ; }
        public Product()
        {
            CreationTime = DateTime.UtcNow;
        }
    }
    
}
