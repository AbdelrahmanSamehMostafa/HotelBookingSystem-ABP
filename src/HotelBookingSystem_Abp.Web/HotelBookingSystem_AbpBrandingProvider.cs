using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace HotelBookingSystem_Abp.Web;

[Dependency(ReplaceServices = true)]
public class HotelBookingSystem_AbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "HotelBookingSystem_Abp";
}
