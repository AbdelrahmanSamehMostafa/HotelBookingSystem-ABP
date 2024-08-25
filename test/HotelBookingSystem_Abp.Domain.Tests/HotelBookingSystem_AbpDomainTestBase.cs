using Volo.Abp.Modularity;

namespace HotelBookingSystem_Abp;

/* Inherit from this class for your domain layer tests. */
public abstract class HotelBookingSystem_AbpDomainTestBase<TStartupModule> : HotelBookingSystem_AbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
