using Microsoft.AspNetCore.Builder;
using HotelBookingSystem_Abp;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<HotelBookingSystem_AbpWebTestModule>();

public partial class Program
{
}
