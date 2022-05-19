using System.Threading.Tasks;
using Abp.Application.Services;
using DukkatTekProject.Sessions.Dto;

namespace DukkatTekProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
