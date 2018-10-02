using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SoccerFieldServer.Core.Entities;
using SoccerFieldServer.Core.Enums;
using SoccerFieldServer.Core.Extensions;
using SoccerFieldServer.Infrastructure.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerFieldServer.Infrastructure.Extensions
{
    public static class AddData
    {
        public static async Task SeedCustomer(UserManager<ApplicationUser> userManager)
        {
            var customerRoleString = Role.Customer.ToDescription();
            var customerClaimString = Claim.Bookfield.ToDescription();

            foreach (var customer in DataValues.CustomerData())
            {
                if (await userManager.FindByNameAsync(customer.UserName) == null)
                {
                    await userManager.CreateAsync(customer, DataValues.default_user_password);

                    var customerClaim = await userManager.GetClaimsAsync(customer);

                    if (!await userManager.IsInRoleAsync(customer, customerRoleString))
                    {
                        await userManager.AddToRoleAsync(customer, customerRoleString);
                    }

                    if (!customerClaim.Any(x => x.Type == customerClaimString))
                    {
                        await userManager.AddClaimAsync(customer, new System.Security.Claims.Claim(customerClaimString, true.ToString()));
                    }
                }
            }
        }

        public static async Task SeedStaff(UserManager<ApplicationUser> userManager)
        {
            var staffRoleString = Role.Staff.ToDescription();
            var staffClaimString = Claim.Bookfield.ToDescription();

            foreach (var staff in DataValues.StaffData())
            {
                if (await userManager.FindByNameAsync(staff.UserName) == null)
                {
                    await userManager.CreateAsync(staff, DataValues.default_user_password);

                    var staffClaim = await userManager.GetClaimsAsync(staff);

                    if (!await userManager.IsInRoleAsync(staff, staffRoleString))
                    {
                        await userManager.AddToRoleAsync(staff, staffRoleString);
                    }                

                    if (!staffClaim.Any(x => x.Type == staffClaimString))
                    {
                        await userManager.AddClaimAsync(staff, new System.Security.Claims.Claim(staffClaimString, true.ToString()));
                    }
                }
            }
        }

        public static async Task SeedOwner(UserManager<ApplicationUser> userManager)
        {
            var ownerRoleString = Role.Owner.ToDescription();
            var ownerFirstClaimString = Claim.CreateNewSoccerField.ToDescription();
            var ownerSecondClaimString = Claim.Bookfield.ToDescription();

            foreach (var owner in DataValues.OwnerData())
            {
                if (await userManager.FindByNameAsync(owner.UserName) == null)
                {
                    await userManager.CreateAsync(owner, DataValues.default_user_password);

                    if (!await userManager.IsInRoleAsync(owner, ownerRoleString))
                    {
                        await userManager.AddToRoleAsync(owner, ownerRoleString);
                    }

                    var ownerClaim = await userManager.GetClaimsAsync(owner);
                    if (!ownerClaim.Any(x => x.Type == ownerFirstClaimString))
                    {
                        await userManager.AddClaimAsync(owner, new System.Security.Claims.Claim(ownerFirstClaimString, true.ToString()));
                    }
                    if (!ownerClaim.Any(x => x.Type == ownerSecondClaimString))
                    {
                        await userManager.AddClaimAsync(owner, new System.Security.Claims.Claim(ownerSecondClaimString, true.ToString()));
                    }
                }
            }
        }

        public static async Task SeedAdmin(UserManager<ApplicationUser> userManager)
        {
            var adminRoleString = Role.Admin.ToDescription();
            var adminClaimString = Claim.CreateNewGrSoccerField.ToDescription();

            foreach (var admin in DataValues.AdminData())
            {
                if (await userManager.FindByNameAsync(admin.UserName) == null)
                {
                    await userManager.CreateAsync(admin, DataValues.default_admin_password);

                    var adminClaim = await userManager.GetClaimsAsync(admin);

                    if (!await userManager.IsInRoleAsync(admin, adminRoleString))
                    {
                        await userManager.AddToRoleAsync(admin, adminRoleString);
                    }

                    if (!adminClaim.Any(x => x.Type == adminClaimString))
                    {
                        await userManager.AddClaimAsync(admin, new System.Security.Claims.Claim(adminClaimString, true.ToString()));
                    }
                }
            }
        }

        public static async Task SeedRolesAndClaims(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var adminRoleString = Role.Admin.ToDescription();
            var ownerRoleString = Role.Owner.ToDescription();
            var staffRoleString = Role.Staff.ToDescription();
            var customerRoleString = Role.Customer.ToDescription();

            var createNewGrSoccerFieldClaimString = Claim.CreateNewGrSoccerField.ToDescription();
            var createNewSoccerFieldClaimString = Claim.CreateNewSoccerField.ToDescription();
            var bookfieldClaimString = Claim.Bookfield.ToDescription();

            if (!await roleManager.RoleExistsAsync(adminRoleString))
            {
                await roleManager.CreateAsync(new IdentityRole
                {
                    Name = adminRoleString
                });
            }

            if (!await roleManager.RoleExistsAsync(ownerRoleString))
            {
                await roleManager.CreateAsync(new IdentityRole
                {
                    Name = ownerRoleString
                });
            }

            if (!await roleManager.RoleExistsAsync(staffRoleString))
            {
                await roleManager.CreateAsync(new IdentityRole
                {
                    Name = staffRoleString
                });
            }

            if (!await roleManager.RoleExistsAsync(customerRoleString))
            {
                await roleManager.CreateAsync(new IdentityRole
                {
                    Name = customerRoleString
                });
            }


            var adminRole = await roleManager.FindByNameAsync(adminRoleString);
            var adminRoleClaims = await roleManager.GetClaimsAsync(adminRole);

            if (!adminRoleClaims.Any(x => x.Type == createNewGrSoccerFieldClaimString))
            {
                await roleManager.AddClaimAsync(adminRole, new System.Security.Claims.Claim(createNewGrSoccerFieldClaimString, "true"));
            }

            var ownerRole = await roleManager.FindByNameAsync(ownerRoleString);
            var ownerRoleClaims = await roleManager.GetClaimsAsync(ownerRole);
            if (!ownerRoleClaims.Any(x => x.Type == createNewSoccerFieldClaimString))
            {
                await roleManager.AddClaimAsync(ownerRole, new System.Security.Claims.Claim(createNewSoccerFieldClaimString, "true"));
            }
            if (!ownerRoleClaims.Any(x => x.Type == bookfieldClaimString))
            {
                await roleManager.AddClaimAsync(ownerRole, new System.Security.Claims.Claim(bookfieldClaimString, "true"));
            }

            var staffRole = await roleManager.FindByNameAsync(staffRoleString);
            var staffRoleClaims = await roleManager.GetClaimsAsync(staffRole);
            if (!staffRoleClaims.Any(x => x.Type == bookfieldClaimString))
            {
                await roleManager.AddClaimAsync(staffRole, new System.Security.Claims.Claim(bookfieldClaimString, "true"));
            }

            var customerRole = await roleManager.FindByNameAsync(customerRoleString);
            var customerRoleClaims = await roleManager.GetClaimsAsync(customerRole);
            if (!customerRoleClaims.Any(x => x.Type == bookfieldClaimString))
            {
                await roleManager.AddClaimAsync(customerRole, new System.Security.Claims.Claim(bookfieldClaimString, "true"));
            }
        }
    }
}
