using HotelBookingSystem_Abp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace HotelBookingSystem_Abp.Permissions;

public class HotelBookingSystem_AbpPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HotelBookingSystem_AbpPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(HotelBookingSystem_AbpPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HotelBookingSystem_AbpResource>(name);
    }
}
