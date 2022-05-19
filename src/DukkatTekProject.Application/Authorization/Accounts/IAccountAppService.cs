using System.Threading.Tasks;
using Abp.Application.Services;
using DukkatTekProject.Authorization.Accounts.Dto;

namespace DukkatTekProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
