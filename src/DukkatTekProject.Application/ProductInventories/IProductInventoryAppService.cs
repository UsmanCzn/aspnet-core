using Abp.Application.Services;
using DukkatTekProject.ProductInventories.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkatTekProject.ProductInventories
{
    public interface IProductInventoryAppService : IApplicationService
    {
        Task<IEnumerable<ProductInventoryDto>> GetAllInventorires();
        Task<IEnumerable<ProductInventoryDto>> GetInventoryById(long invId);
        Task<IEnumerable<ProductInventoryDto>> SellProduct(long productId);
    }
}
