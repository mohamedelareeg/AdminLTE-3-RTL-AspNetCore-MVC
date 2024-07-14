using AdminLTE.Services.Abstractions;

namespace AdminLTE.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(ApplicationDbContext context, IFunctional functional)
        {
            context.Database.EnsureCreated();
            if (context.ApplicationUser.Any())
            {
                return;
            }
            else
            {
                await functional.CreateDefaultSuperAdmin();
            }
        }
    }
}
