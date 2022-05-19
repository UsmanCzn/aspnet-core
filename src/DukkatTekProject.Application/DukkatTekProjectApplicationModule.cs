using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DukkatTekProject.Authorization;

namespace DukkatTekProject
{
    [DependsOn(
        typeof(DukkatTekProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DukkatTekProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DukkatTekProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DukkatTekProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
