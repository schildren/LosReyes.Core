using Volo.Abp.Settings;

namespace LosReyes.core.Settings
{
    public class coreSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(coreSettings.MySetting1));
        }
    }
}
