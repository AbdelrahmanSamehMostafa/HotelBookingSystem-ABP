using Volo.Abp.Modularity;

namespace HotelBookingSystem_Abp;

public abstract class HotelBookingSystem_AbpApplicationTestBase<TStartupModule> : HotelBookingSystem_AbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
