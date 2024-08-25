using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace HotelBookingSystem_Abp.Pages;

[Collection(HotelBookingSystem_AbpTestConsts.CollectionDefinitionName)]
public class Index_Tests : HotelBookingSystem_AbpWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
