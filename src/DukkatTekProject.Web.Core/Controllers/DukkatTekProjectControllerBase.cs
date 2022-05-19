using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DukkatTekProject.Controllers
{
    public abstract class DukkatTekProjectControllerBase: AbpController
    {
        protected DukkatTekProjectControllerBase()
        {
            LocalizationSourceName = DukkatTekProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
