using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DukkatTekProject.EntityFrameworkCore;
using DukkatTekProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace DukkatTekProject.Web.Tests
{
    [DependsOn(
        typeof(DukkatTekProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DukkatTekProjectWebTestModule : AbpModule
    {
        public DukkatTekProjectWebTestModule(DukkatTekProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DukkatTekProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DukkatTekProjectWebMvcModule).Assembly);
        }
    }
}