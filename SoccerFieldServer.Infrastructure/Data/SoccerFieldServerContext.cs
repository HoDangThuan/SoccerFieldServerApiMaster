using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoccerFieldServer.Core.Entities;

namespace SoccerFieldServer.Infrastructure.Data
{
    public class SoccerFieldServerContext : IdentityDbContext<ApplicationUser>
    {
        public SoccerFieldServerContext(DbContextOptions<SoccerFieldServerContext> options) : base(options)
        { }

        public SoccerFieldServerContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<DetailsOfBookField>().HasKey(table => new {
                table.BookFieldId,
                table.ProductId
            });
            builder.Entity<CustomerHistory>().HasKey(table => new {
                table.CustomerId,
                table.BookFieldId
            });
            builder.Entity<WorkScheduleStaff>().HasKey(table => new {
                table.StaffUserName,
                table.Day,
                table.Shift
            });
            builder.Entity<User_GroupSoccerField>().HasKey(table => new {
                table.UserId
            });
        }


        public DbSet<GroupSoccerField> GroupSoccerFields { get; set; }
        public DbSet<SoccerField> SoccerFields { get; set; }
        public DbSet<WorkScheduleStaff> WorkScheduleStaffs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BookField> BookFields { get; set; }        
        public DbSet<DetailsOfBookField> DetailsOfBookFields { get; set; }
        public DbSet<CustomerHistory> CustomerHistorys { get; set; }
        public DbSet<User_GroupSoccerField> User_GroupSoccerFields { get; set; }
    }

}
