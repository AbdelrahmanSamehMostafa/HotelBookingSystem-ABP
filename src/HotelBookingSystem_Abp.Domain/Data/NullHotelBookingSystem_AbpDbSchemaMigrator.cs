using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HotelBookingSystem_Abp.Data;

/* This is used if database provider does't define
 * IHotelBookingSystem_AbpDbSchemaMigrator implementation.
 */
public class NullHotelBookingSystem_AbpDbSchemaMigrator : IHotelBookingSystem_AbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
