using Volo.Abp.Modularity;

namespace HotelBookingSystem_Abp;

[DependsOn(
    typeof(HotelBookingSystem_AbpApplicationModule),
    typeof(HotelBookingSystem_AbpDomainTestModule)
)]
public class HotelBookingSystem_AbpApplicationTestModule : AbpModule
{

}
