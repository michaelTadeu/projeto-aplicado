using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using insideNutri.EntityFrameworkCore;
using insideNutri.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace insideNutri.Web.Tests
{
    [DependsOn(
        typeof(insideNutriWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class insideNutriWebTestModule : AbpModule
    {
        public insideNutriWebTestModule(insideNutriEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(insideNutriWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(insideNutriWebMvcModule).Assembly);
        }
    }
}