using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkatTekProject.ProductInventories.Dto
{
    public class ProductInventoryMapProfile : Profile
    {
        public ProductInventoryMapProfile()
        {
            CreateMap<ProductInventoryDto, ProductInventory>()
               .ForMember(c => c.Id, options => options.MapFrom(input => input.Id))
               .ForMember(c => c.InventoryName, options => options.MapFrom(input => input.InventoryName))
                .ForMember(c => c.ProductId, options => options.MapFrom(input => input.ProductId))
                 .ForMember(c => c.InventoryQuantity, options => options.MapFrom(input => input.InventoryQuantity))
               
                
                .ForMember(c => c.CreationTime, options => options.MapFrom(input => input.CreationTime))
                 .ForMember(c => c.TenantId, options => options.MapFrom(input => input.TenantId));

            CreateMap<ProductInventory, ProductInventoryDto>()
              .ForMember(c => c.Id, options => options.MapFrom(input => input.Id))
              .ForMember(c => c.InventoryName, options => options.MapFrom(input => input.InventoryName))
               .ForMember(c => c.ProductId, options => options.MapFrom(input => input.ProductId))
                 .ForMember(c => c.InventoryQuantity, options => options.MapFrom(input => input.InventoryQuantity));

        }
    }
}
