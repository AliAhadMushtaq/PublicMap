using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Maps.EntityFrameworkCore;
using Maps.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Maps.Web.Tests
{
    [DependsOn(
        typeof(MapsWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MapsWebTestModule : AbpModule
    {
        public MapsWebTestModule(MapsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MapsWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MapsWebMvcModule).Assembly);
        }
    }
}