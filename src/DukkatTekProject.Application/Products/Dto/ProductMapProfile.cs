using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkatTekProject.Products.Dto
{
    public class ProductMapProfile : Profile
    {
        public ProductMapProfile()
        {
            CreateMap<ProductDto, Product>()
                .ForMember(c => c.Id, options => options.MapFrom(input => input.Id))
                .ForMember(c => c.Name, options => options.MapFrom(input => input.Name))
                .ForMember(c => c.Barcode, options => options.MapFrom(input => input.Barcode))
                .ForMember(c => c.Description, options => options.MapFrom(input => input.Description))
                .ForMember(c => c.Weight, options => options.MapFrom(input => input.Weight))
                .ForMember(c => c.ProductCategoryId, options => options.MapFrom(input => input.ProductCategoryId))
                 .ForMember(c => c.ProductCategory, options => options.Ignore())
                .ForMember(c => c.ProductStatus, options => options.MapFrom(input => input.ProductStatus))
                 .ForMember(c => c.CreationTime, options => options.MapFrom(input => input.CreationTime))
                  .ForMember(c => c.TenantId, options => options.MapFrom(input => input.TenantId));

            CreateMap<Product, ProductDto>()
              .ForMember(c => c.Id, options => options.MapFrom(input => input.Id))
              .ForMember(c => c.Name, options => options.MapFrom(input => input.Name))
              .ForMember(c => c.Barcode, options => options.MapFrom(input => input.Barcode))
              .ForMember(c => c.Description, options => options.MapFrom(input => input.Description))
              .ForMember(c => c.Weight, options => options.MapFrom(input => input.Weight))
              .ForMember(c => c.ProductCategoryId, options => options.MapFrom(input => input.ProductCategoryId))
              .ForMember(c => c.ProductStatus, options => options.MapFrom(input => input.ProductStatus));
            
        }
    }
}
