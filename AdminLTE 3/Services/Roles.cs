using AdminLTE.Contants;
using AdminLTE.Data;
using AdminLTE.Enums;
using AdminLTE.Models;
using AdminLTE.Services.Abstractions;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace AdminLTE.Services
{
    public class Roles : IRoles
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public Roles(RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager,
                ApplicationDbContext context)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }
        public async Task AddToRoles(string applicationUserId)
        {
            var user = await _userManager.FindByIdAsync(applicationUserId);
            if (user != null)
            {
                var roles = _roleManager.Roles;
                List<string> listRoles = new List<string>();
                foreach (var item in roles)
                {
                    listRoles.Add(item.Name);
                }
                await _userManager.AddToRolesAsync(user, listRoles);
            }
        }
        public async Task GenerateRolesFromPagesAsync()
        {
            if (!await _roleManager.RoleExistsAsync(DefaultRoles.ADMIN.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = DefaultRoles.ADMIN.ToString() });
            }
            var adminRole = await _roleManager.FindByNameAsync(DefaultRoles.ADMIN.ToString());
            var _GetModulesList = Permissions.permissionList;
            foreach (var item in _GetModulesList)
            {
                if (!item!.ToString().Equals(""))
                {
                    await AddPermissionClaims(adminRole, item);
                }
            }

        }
        public async Task AddPermissionClaims(IdentityRole role, string module)
        {
            var allClaims = await _roleManager.GetClaimsAsync(role);
            var allPermissions = Permissions.GeneratePermissionsList(module);

            foreach (var permission in allPermissions)
            {
                if (!allClaims.Any(c => c.Type == "Permission" && c.Value == permission))
                    await _roleManager.AddClaimAsync(role, new Claim("Permission", permission));
            }
        }
    }
}
