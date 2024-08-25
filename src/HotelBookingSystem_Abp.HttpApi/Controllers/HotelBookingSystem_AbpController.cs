using HotelBookingSystem_Abp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HotelBookingSystem_Abp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HotelBookingSystem_AbpController : AbpControllerBase
{
    protected HotelBookingSystem_AbpController()
    {
        LocalizationResource = typeof(HotelBookingSystem_AbpResource);
    }
}
