using System.Threading.Tasks;

namespace HotelBookingSystem_Abp.Data;

public interface IHotelBookingSystem_AbpDbSchemaMigrator
{
    Task MigrateAsync();
}
