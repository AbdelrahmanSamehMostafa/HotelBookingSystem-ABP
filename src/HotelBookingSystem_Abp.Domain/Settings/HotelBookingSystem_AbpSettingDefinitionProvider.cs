using Volo.Abp.Settings;

namespace HotelBookingSystem_Abp.Settings;

public class HotelBookingSystem_AbpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HotelBookingSystem_AbpSettings.MySetting1));
    }
}
