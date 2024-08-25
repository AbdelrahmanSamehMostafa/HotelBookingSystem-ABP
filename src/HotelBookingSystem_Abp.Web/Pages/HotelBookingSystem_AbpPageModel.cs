using HotelBookingSystem_Abp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace HotelBookingSystem_Abp.Web.Pages;

public abstract class HotelBookingSystem_AbpPageModel : AbpPageModel
{
    protected HotelBookingSystem_AbpPageModel()
    {
        LocalizationResourceType = typeof(HotelBookingSystem_AbpResource);
    }
}
