using Microsoft.EntityFrameworkCore;

namespace SoccerFieldServer.api.App_Start
{
    public class SoccerFieldDbContextConfig
    {
        public static void Config(DbContextOptionsBuilder options)
        {
            var connectionString = Startup.Configuration["identity_db_connection_string"];
            options.UseNpgsql(connectionString, b => b.MigrationsAssembly("SoccerFieldServer.api"));
        }
    }
}