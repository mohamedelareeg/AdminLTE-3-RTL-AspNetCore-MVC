using AdminLTE.Data;
using AdminLTE.Models;
using AdminLTE.Services.Abstractions;
using Microsoft.AspNetCore.Identity;

namespace AdminLTE.Services
{
    public class Functional : IFunctional
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IRoles _roles;
        public Functional(UserManager<ApplicationUser> userManager, ApplicationDbContext context, IRoles roles)
        {
            _userManager = userManager;
            _context = context;
            _roles = roles;
        }

        public async Task CreateDefaultSuperAdmin()
        {
            try
            {

                await _roles.GenerateRolesFromPagesAsync();
                ApplicationUser superAdmin = new ApplicationUser();
                superAdmin.Email = "admin@gmail.com";
                superAdmin.UserName = superAdmin.Email;
                superAdmin.EmailConfirmed = true;
                superAdmin.PhoneNumber = "0100000000";

                var result = await _userManager.CreateAsync(superAdmin, "123");

                if (result.Succeeded)
                {

                    await _roles.AddToRoles(superAdmin.Id);


                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
