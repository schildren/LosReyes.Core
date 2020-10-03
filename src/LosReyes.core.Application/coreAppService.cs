using System;
using System.Collections.Generic;
using System.Text;
using LosReyes.core.Localization;
using Volo.Abp.Application.Services;

namespace LosReyes.core
{
    /* Inherit your application services from this class.
     */
    public abstract class coreAppService : ApplicationService
    {
        protected coreAppService()
        {
            LocalizationResource = typeof(coreResource);
        }
    }
}
