using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkatTekProject.ProductInventories.Dto
{
    public class ProductInventoryDto
    {
        public long Id { get; set; }
        [Required]
        public string InventoryName { get; set; }//Like Sold,InStock,Damaged
        [Required]
        public int ProductId { get; set; }
        public int InventoryQuantity { get; set; }
        public DateTime CreationTime { get; set; }
        public int? TenantId { get; set; }
        
    }
}
