using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HotelBookingSystem_Abp.Data;
using Volo.Abp.DependencyInjection;

namespace HotelBookingSystem_Abp.EntityFrameworkCore;

public class EntityFrameworkCoreHotelBookingSystem_AbpDbSchemaMigrator
    : IHotelBookingSystem_AbpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHotelBookingSystem_AbpDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the HotelBookingSystem_AbpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HotelBookingSystem_AbpDbContext>()
            .Database
            .MigrateAsync();
    }
}
