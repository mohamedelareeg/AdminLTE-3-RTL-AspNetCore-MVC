namespace AdminLTE.Contants
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


    }
}
