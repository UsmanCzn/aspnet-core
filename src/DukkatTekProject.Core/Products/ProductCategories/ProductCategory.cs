using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkatTekProject.Products.ProductCategories
{
    [Table("ProductCategories")]
    public class ProductCategory : Entity, IHasCreationTime, IMayHaveTenant, IHasDeletionTime
    {
        public string Name { get; set; }


        public DateTime CreationTime { get; set; }
        public int? TenantId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
