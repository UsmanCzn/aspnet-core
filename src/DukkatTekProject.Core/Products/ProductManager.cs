using Abp.Dependency;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkatTekProject.Products
{
    public class ProductManager : ITransientDependency
    {
        private readonly IRepository<Product, long> _productRepository;
        public ProductManager(IRepository<Product, long> productRepository)
        {
            _productRepository = productRepository;
        }
        //For Product CRUD

        public async Task<Product> ChangeStatus(long productId, ProductStatus ProductStatus) {

            //logic add to InStock or Damage or Sold;

            var product = await _productRepository.FirstOrDefaultAsync(x => x.Id == productId);
            product.ProductStatus = ProductStatus;
            return await _productRepository.UpdateAsync(product);
        }
    }
}
