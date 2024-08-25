using HotelBookingSystem_Abp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace HotelBookingSystem_Abp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HotelBookingSystem_AbpEntityFrameworkCoreModule),
    typeof(HotelBookingSystem_AbpApplicationContractsModule)
)]
public class HotelBookingSystem_AbpDbMigratorModule : AbpModule
{
}
