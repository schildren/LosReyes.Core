using LosReyes.core.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LosReyes.core.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class coreController : AbpController
    {
        protected coreController()
        {
            LocalizationResource = typeof(coreResource);
        }
    }
}