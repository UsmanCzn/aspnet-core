using Abp.Application.Services;
using DukkatTekProject.ProductInventories.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkatTekProject.ProductInventories
{
    public class ProductInventoryAppService : ApplicationService, IProductInventoryAppService
    {
        private readonly ProductInventoryManager _productInventoryManager;
        public ProductInventoryAppService(ProductInventoryManager productInventoryManager)
        {
            _productInventoryManager = productInventoryManager;
        }
        public async Task<IEnumerable<ProductInventoryDto>> GetAllInventorires()
        {
            var result = await _productInventoryManager.GetAll();
            return ObjectMapper.Map<IEnumerable<ProductInventoryDto>>(result);
        }

        public async Task<IEnumerable<ProductInventoryDto>> GetInventoryById(long invId)
        {
            var result = await _productInventoryManager.GetInventoryById(invId);
            return ObjectMapper.Map<IEnumerable<ProductInventoryDto>>(result);
        }

        public async Task<IEnumerable<ProductInventoryDto>> SellProduct(long productId)
        {
            var result = await _productInventoryManager.SellProduct(productId);
            return ObjectMapper.Map<IEnumerable<ProductInventoryDto>>(result);
        }
    }
}
