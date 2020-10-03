using LosReyes.core.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LosReyes.core.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class corePageModel : AbpPageModel
    {
        protected corePageModel()
        {
            LocalizationResourceType = typeof(coreResource);
        }
    }
}