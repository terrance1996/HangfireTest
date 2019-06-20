using Volo.Abp.Settings;

namespace HangfireTest.Settings
{
    public class HangfireTestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(HangfireTestSettings.MySetting1));
        }
    }
}
