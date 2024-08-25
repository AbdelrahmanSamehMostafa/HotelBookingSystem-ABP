using BookingSystem.Models;
using Microsoft.AspNetCore.Identity;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using System.Threading.Tasks;

public class SuperAdminSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<SuperAdmin, int> _superAdminRepository;

    public SuperAdminSeedContributor(IRepository<SuperAdmin, int> superAdminRepository)
    {
        _superAdminRepository = superAdminRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _superAdminRepository.GetCountAsync() == 0)
        {
            var superAdmin = new SuperAdmin
            {
                Name = "admin",
                Password = "admin"
            };

            await _superAdminRepository.InsertAsync(superAdmin);
        }
    }
}
