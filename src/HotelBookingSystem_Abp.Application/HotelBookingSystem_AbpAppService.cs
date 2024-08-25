using HotelBookingSystem_Abp.Localization;
using Volo.Abp.Application.Services;

namespace HotelBookingSystem_Abp;

/* Inherit your application services from this class.
 */
public abstract class HotelBookingSystem_AbpAppService : ApplicationService
{
    protected HotelBookingSystem_AbpAppService()
    {
        LocalizationResource = typeof(HotelBookingSystem_AbpResource);
    }
}
