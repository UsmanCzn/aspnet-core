using Abp.Application.Services;
using DukkatTekProject.MultiTenancy.Dto;

namespace DukkatTekProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

