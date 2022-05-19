using Abp.Dependency;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkatTekProject.Products.ProductCategories
{
    public class ProductCategoryManager : ITransientDependency
    {
        private readonly IRepository<ProductCategory> _productCategoryRepository;
        public ProductCategoryManager(IRepository<ProductCategory> productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }
    }
}
