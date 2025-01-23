using Assocuation.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Assocuation.Permissions;

public class AssocuationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AssocuationPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AssocuationPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AssocuationResource>(name);
    }
}
