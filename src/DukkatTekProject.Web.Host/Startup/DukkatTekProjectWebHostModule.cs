using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DukkatTekProject.Configuration;

namespace DukkatTekProject.Web.Host.Startup
{
    [DependsOn(
       typeof(DukkatTekProjectWebCoreModule))]
    public class DukkatTekProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DukkatTekProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DukkatTekProjectWebHostModule).GetAssembly());
        }
    }
}
