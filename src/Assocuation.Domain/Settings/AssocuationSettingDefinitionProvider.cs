using Volo.Abp.Settings;

namespace Assocuation.Settings;

public class AssocuationSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AssocuationSettings.MySetting1));
    }
}
