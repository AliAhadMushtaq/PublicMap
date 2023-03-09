using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Maps.Controllers
{
    public abstract class MapsControllerBase: AbpController
    {
        protected MapsControllerBase()
        {
            LocalizationSourceName = MapsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
