namespace AdminLTE.Constants
{
    public static class Permissions
    {
        public static List<string> permissionList = new List<string>
                {
                    "Employee"
                };
        public static List<string> GeneratePermissionsList(string module)
        {
            return new List<string>()
            {
                $"Permissions.System.{module}.View",
                $"Permissions.System.{module}.Create",
                $"Permissions.System.{module}.Edit",
                $"Permissions.System.{module}.Delete"
            };
        }
        public static List<string> GenerateAllPermissions(List<string> _permissons)
        {
            var allPermissions = new List<string>();

            foreach (var permisson in _permissons)
                allPermissions.AddRange(GeneratePermissionsList(permisson));
            return allPermissions;
        }

    }
}
