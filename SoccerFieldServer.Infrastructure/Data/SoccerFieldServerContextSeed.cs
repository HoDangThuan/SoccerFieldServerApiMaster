using SoccerFieldServer.Core.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using SoccerFieldServer.Infrastructure.Extensions;

namespace SoccerFieldServer.Infrastructure.Data
{
    public class SoccerFieldServerContextSeed
    {
        public static async Task SeedAsync(SoccerFieldServerContext dbContext,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;
            try
            {
                dbContext.Database.Migrate();
                await AddData.SeedRolesAndClaims(userManager, roleManager);

                await AddData.SeedAdmin(userManager);
                await AddData.SeedOwner(userManager);
                await AddData.SeedStaff(userManager);
                await AddData.SeedCustomer(userManager);

                if (!dbContext.GroupSoccerFields.Any())
                {
                    dbContext.GroupSoccerFields.AddRange(DataValues.GroupSoccerFieldData());
                    await dbContext.SaveChangesAsync();
                }
                if (!dbContext.SoccerFields.Any())
                {
                    dbContext.SoccerFields.AddRange(DataValues.SoccerFieldData());
                    await dbContext.SaveChangesAsync();
                }
                if (!dbContext.Products.Any())
                {
                    dbContext.Products.AddRange(DataValues.ProductData());
                    await dbContext.SaveChangesAsync();
                }
                if (!dbContext.User_GroupSoccerFields.Any())
                {
                    dbContext.User_GroupSoccerFields.AddRange(DataValues.User_GroupSoccerFieldData());
                    await dbContext.SaveChangesAsync();
                }
                if (!dbContext.WorkScheduleStaffs.Any())
                {
                    dbContext.WorkScheduleStaffs.AddRange(DataValues.WorkScheduleStaffData());
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<SoccerFieldServerContext>();
                    log.LogError(ex.Message);
                    await SeedAsync(dbContext, userManager, roleManager, loggerFactory, retryForAvailability);
                }
            }

        }

    }
}