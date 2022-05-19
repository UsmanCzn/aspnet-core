using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

using DukkatTekProject.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkatTekProject.ProductInventories
{
    [Table("ProductInventories")]
    public class ProductInventory : Entity<long>, IHasCreationTime, IMayHaveTenant, IHasDeletionTime
    {

        [Required]
        public string InventoryName { get; set; }//Like Sold,InStock,Damaged


        [Required]
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int InventoryQuantity { get; set; }


        public DateTime CreationTime { get; set; }
        public int? TenantId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
        public ProductInventory()
        {
            Product = new Product();
        }

    }
}
