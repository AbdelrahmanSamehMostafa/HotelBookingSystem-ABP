using HotelBookingSystem_Abp.Samples;
using Xunit;

namespace HotelBookingSystem_Abp.EntityFrameworkCore.Domains;

[Collection(HotelBookingSystem_AbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<HotelBookingSystem_AbpEntityFrameworkCoreTestModule>
{

}
