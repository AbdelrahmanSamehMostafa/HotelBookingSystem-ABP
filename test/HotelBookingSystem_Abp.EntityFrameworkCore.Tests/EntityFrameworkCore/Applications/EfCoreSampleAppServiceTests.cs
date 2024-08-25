using HotelBookingSystem_Abp.Samples;
using Xunit;

namespace HotelBookingSystem_Abp.EntityFrameworkCore.Applications;

[Collection(HotelBookingSystem_AbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<HotelBookingSystem_AbpEntityFrameworkCoreTestModule>
{

}
