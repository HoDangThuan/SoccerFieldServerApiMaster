using System.ComponentModel;

namespace SoccerFieldServer.Core.Enums
{
    public enum Role
    {
        [Description("admin")]
        Admin = 1,
        [Description("owner")]
        Owner = 2,
        [Description("staff")]
        Staff = 3,
        [Description("customer")]
        Customer = 4
    }
}