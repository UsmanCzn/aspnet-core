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
    public interface IProductAppService : IApplicationService
    {
        Task<ProductDto> ChangeStatus(long productId, ProductStatus ProductStatus);

    }
}
