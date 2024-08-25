using Volo.Abp.Modularity;

namespace HotelBookingSystem_Abp;

[DependsOn(
    typeof(HotelBookingSystem_AbpDomainModule),
    typeof(HotelBookingSystem_AbpTestBaseModule)
)]
public class HotelBookingSystem_AbpDomainTestModule : AbpModule
{

}
