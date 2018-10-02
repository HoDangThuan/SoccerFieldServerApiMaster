using System.ComponentModel;

namespace SoccerFieldServer.Core.Enums
{
    public enum UserPostion
    {
        [Description("Chủ Sân")]
        Owner = 1,
        [Description("Nhân viên bán hàng")]
        Seller = 2,
        [Description("Nhân viên quản lý")]
        Manager = 3,
        [Description("Khách hàng")]
        Customer = 4
    }
}
