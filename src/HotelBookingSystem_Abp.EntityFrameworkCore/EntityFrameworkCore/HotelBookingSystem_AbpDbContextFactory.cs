using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HotelBookingSystem_Abp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class HotelBookingSystem_AbpDbContextFactory : IDesignTimeDbContextFactory<HotelBookingSystem_AbpDbContext>
{
    public HotelBookingSystem_AbpDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        HotelBookingSystem_AbpEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<HotelBookingSystem_AbpDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new HotelBookingSystem_AbpDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../HotelBookingSystem_Abp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
