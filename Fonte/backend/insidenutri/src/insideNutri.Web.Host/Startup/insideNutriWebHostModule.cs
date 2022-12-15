using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using insideNutri.Configuration;

namespace insideNutri.Web.Host.Startup
{
    [DependsOn(
       typeof(insideNutriWebCoreModule))]
    public class insideNutriWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public insideNutriWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(insideNutriWebHostModule).GetAssembly());
        }
    }
}
