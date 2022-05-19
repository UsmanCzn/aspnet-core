using Abp.Application.Services;
using DukkatTekProject.Products.Dto;
using DukkatTekProject.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkatTekProject.Products
{
    public class ProductAppService : ApplicationService, IProductAppService
    {
        private readonly ProductManager _productManager;
        public ProductAppService(ProductManager productManager)
        {
            _productManager = productManager;
        }
        public async Task<ProductDto> ChangeStatus(long productId, ProductStatus ProductStatus)
        {
          var result = await _productManager.ChangeStatus( productId,  ProductStatus);
            return ObjectMapper.Map<ProductDto>(result);

        }
    }
}
