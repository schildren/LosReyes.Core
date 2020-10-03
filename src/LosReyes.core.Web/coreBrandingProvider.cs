using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace LosReyes.core.Web
{
    [Dependency(ReplaceServices = true)]
    public class coreBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "core";
    }
}
