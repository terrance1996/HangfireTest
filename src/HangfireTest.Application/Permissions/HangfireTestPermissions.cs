using System;
using Volo.Abp.Reflection;

namespace HangfireTest.Permissions
{
    public static class HangfireTestPermissions
    {
        public const string GroupName = "HangfireTest";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public static string[] GetAll()
        {
            //Return an array of all permissions
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(HangfireTestPermissions));
        }
    }
}