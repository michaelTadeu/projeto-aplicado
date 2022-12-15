using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using insideNutri.Authorization;

namespace insideNutri
{
    [DependsOn(
        typeof(insideNutriCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class insideNutriApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<insideNutriAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(insideNutriApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
