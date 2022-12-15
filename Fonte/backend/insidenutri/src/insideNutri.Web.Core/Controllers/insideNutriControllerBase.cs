using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace insideNutri.Controllers
{
    public abstract class insideNutriControllerBase: AbpController
    {
        protected insideNutriControllerBase()
        {
            LocalizationSourceName = insideNutriConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
