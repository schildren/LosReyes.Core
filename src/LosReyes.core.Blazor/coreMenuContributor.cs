using System.Threading.Tasks;
using LosReyes.core.Localization;
using Volo.Abp.UI.Navigation;

namespace LosReyes.core.Blazor
{
    public class coreMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<coreResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "core.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
