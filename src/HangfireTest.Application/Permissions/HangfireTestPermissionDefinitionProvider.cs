using HangfireTest.Localization.HangfireTest;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HangfireTest.Permissions
{
    public class HangfireTestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(HangfireTestPermissions.GroupName);

            //Define your own permissions here. Examaple:
            //myGroup.AddPermission(HangfireTestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<HangfireTestResource>(name);
        }
    }
}
