using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DukkatTekProject.Configuration.Dto;

namespace DukkatTekProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DukkatTekProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
