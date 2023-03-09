using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Maps.Authorization;

namespace Maps
{
    [DependsOn(
        typeof(MapsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MapsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MapsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MapsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
