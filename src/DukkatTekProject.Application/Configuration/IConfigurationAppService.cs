using System.Threading.Tasks;
using DukkatTekProject.Configuration.Dto;

namespace DukkatTekProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
