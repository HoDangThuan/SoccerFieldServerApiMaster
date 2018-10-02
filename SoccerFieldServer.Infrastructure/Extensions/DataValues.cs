using SoccerFieldServer.Core.Entities;
using SoccerFieldServer.Core.Enums;
using SoccerFieldServer.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace SoccerFieldServer.Infrastructure.Extensions
{
    public static class DataValues
    {
        public const string default_admin_password = "Abc123!@#";
        public const string default_user_password = "Abc123!@#";
        static CultureInfo ci = CultureInfo.InvariantCulture;
        public static IEnumerable<ApplicationUser> AdminData()
        {
            return new List<ApplicationUser>()
            {
                new ApplicationUser { UserName = "Admin01", Email = "NguyenVanQuan@yahoo.com", SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Quản", LastName = "Nguyễn Văn", EmailConfirmed = true, Address = "33 Nguyễn Thị Thập, Đà Nẵng",
                    BankAcount = "0109876523", IsEnabled = true, Note = "Admin", Sex = Sex.Male.ToDescription(),
                    DateOfBirth = DateTime.ParseExact("25/12/1965", "dd/MM/yyyy", ci), PhoneNumber =  "0935846275"},
                new ApplicationUser { UserName = "Admin02", Email = "TranThiTri@gmail.com", SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Trị", LastName = "Trần Thị", EmailConfirmed = true, Address = "128 Trương Định, Đà Nẵng",
                    BankAcount = "0108658244", IsEnabled = true, Note = "Admin", Sex = Sex.Female.ToDescription(),
                    DateOfBirth = DateTime.ParseExact("12/02/1971", "dd/MM/yyyy", ci), PhoneNumber =  "0985234612" }
            };
        }
        public static IEnumerable<ApplicationUser> OwnerData()
        {
            return new List<ApplicationUser>()
            {
                new ApplicationUser { UserName = "C00001CS0001", Email = "NguyenVanOngChu@yahoo.com", SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Chủ", LastName = "Nguyễn Văn Ông", EmailConfirmed = true, Address = "64 Tôn Đản, Đà Nẵng",
                    BankAcount = "0102385622", IsEnabled = true, Note = "Owner", Sex = Sex.Male.ToDescription(),
                    DateOfBirth = DateTime.ParseExact("20/11/1962", "dd/MM/yyyy", ci), PhoneNumber =  "0935846275" },
                new ApplicationUser { UserName = "C00002CS0001", Email = "HoThiBaChu@yahoo.com", SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Chủ", LastName = "Hồ Thị Bà", EmailConfirmed = true, Address = "67 Điện Biên Phủ, Đà Nẵng",
                    BankAcount = "0102388745", IsEnabled = true, Note = "Owner", Sex = Sex.Female.ToDescription(),
                    DateOfBirth = DateTime.ParseExact("13/01/1968", "dd/MM/yyyy", ci), PhoneNumber =  "0945628531" }
            };
        }
        public static IEnumerable<ApplicationUser> StaffData()
        {
            return new List<ApplicationUser>()
            {
                new ApplicationUser { UserName = "C00001NV0001", Email = "LeQuangTrung@yahoo.com", SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Trung", LastName = "Lê Quang", EmailConfirmed = true, Address = "100 Phan Bội Châu, Đà Nẵng",
                    BankAcount = "0102382412", IsEnabled = true, Note = "Staff", Sex = Sex.Male.ToDescription(),
                    DateOfBirth = DateTime.ParseExact("20/11/1989", "dd/MM/yyyy", ci), PhoneNumber =  "0932986213" },
                new ApplicationUser { UserName = "C00001NV0002", Email = "LeQuangDinh@yahoo.com", SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Định", LastName = "Lê Quang", EmailConfirmed = true, Address = "100 Nguyễn Công Trứ, Huế",
                    BankAcount = "0105395472", IsEnabled = true, Note = "Staff", Sex = Sex.Male.ToDescription(),
                    DateOfBirth = DateTime.ParseExact("12/01/1992", "dd/MM/yyyy", ci), PhoneNumber =  "0935684216" },
                new ApplicationUser { UserName = "C00001NV0003", Email = "LeQuangDinh@yahoo.com", SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Định", LastName = "Lê Quang", EmailConfirmed = true, Address = "100 Nguyễn Công Trứ, Huế",
                    BankAcount = "0109567455", IsEnabled = true, Note = "Staff", Sex = Sex.Male.ToDescription(),
                    DateOfBirth = DateTime.ParseExact("10/11/1995", "dd/MM/yyyy", ci), PhoneNumber =  "0935856475" },
                new ApplicationUser { UserName = "C00002NV0001", Email = "DinhPhamTuyen@yahoo.com", SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Tuyên", LastName = "Đinh Phạm", EmailConfirmed = true, Address = "122 Nguyễn Công Trứ, Đà Nẵng",
                    BankAcount = "0103574688", IsEnabled = true, Note = "Staff", Sex = Sex.Male.ToDescription(),
                    DateOfBirth = DateTime.ParseExact("04/11/1996", "dd/MM/yyyy", ci), PhoneNumber =  "0935867412" }
            };
        }
        public static IEnumerable<ApplicationUser> CustomerData()
        {
            return new List<ApplicationUser>()
            {
                new ApplicationUser { UserName = "HoDangThuan", Email = "HoDangThuan@yahoo.com", SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Thuần", LastName = "Hồ Đăng", EmailConfirmed = true, Address = "33 Tô Hiệu, Huế",
                    BankAcount = "0102396472", IsEnabled = true, Note = "Customer", Sex = Sex.Male.ToDescription(),
                    DateOfBirth = DateTime.ParseExact("18/08/1989", "dd/MM/yyyy", ci), PhoneNumber =  "0965784235" },
                new ApplicationUser { UserName = "NguyenVanHien", Email = "NguyenVanHien@yahoo.com", SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Hiền", LastName = "Nguyễn Văn", EmailConfirmed = true, Address = "73 Tô Thất Tùng, Huế",
                    BankAcount = "0102382465", IsEnabled = true, Note = "Customer", Sex = Sex.Female.ToDescription(),
                    DateOfBirth = DateTime.ParseExact("20/10/1995", "dd/MM/yyyy", ci), PhoneNumber =  "0965847596" }
            };
        }
        public static IEnumerable<GroupSoccerField> GroupSoccerFieldData()
        {
            return new List<GroupSoccerField>()
            {
                new GroupSoccerField { Id = "C00001", Name = "Sân bóng Tiểu La", Address = "100 Tiểu La", District = "Đà Nẵng", Country = "Việt Nam",
                    OpenTime = new TimeSpan(0, 5, 0, 0, 0), CloseTime = new TimeSpan(0, 23, 0, 0), PercentVAT = 10, PercentPunish = 20,
                    PercentRushHour = 50, IsEnable = true, Latlng_latitude = 16.045337, Latlng_longitude = 108.212987, Note = "Bình Thường"},
                new GroupSoccerField { Id = "C00002", Name = "Sân bóng Đức Nam", Address = "146 Duy Tân", District = "Đà Nẵng", Country = "Việt Nam",
                    OpenTime = new TimeSpan(0, 5, 0, 0, 0), CloseTime = new TimeSpan(0, 23, 0, 0), PercentVAT = 10, PercentPunish = 20,
                    PercentRushHour = 50, IsEnable = true, Latlng_latitude = 16.052599, Latlng_longitude = 108.206591, Note = "Bình Thường"},
                new GroupSoccerField { Id = "C00003", Name = "Sân bóng mini Bế Văn Đàn", Address = "265 Điện Biên Phủ", District = "Đà Nẵng", Country = "Việt Nam",
                    OpenTime = new TimeSpan(0, 5, 0, 0, 0), CloseTime = new TimeSpan(0, 23, 0, 0), PercentVAT = 10, PercentPunish = 20,
                    PercentRushHour = 50, IsEnable = false, Latlng_latitude = 16.065882, Latlng_longitude = 108.193927, Note = "Đang sửa chữa"}
            };
        }
        public static IEnumerable<User_GroupSoccerField> User_GroupSoccerFieldData()
        {
            return new List<User_GroupSoccerField>()
            {
                new User_GroupSoccerField { UserId = "C00001CS0001", GroupSoccerFieldId = "C00001", Position = UserPostion.Owner.ToDescription() },
                new User_GroupSoccerField { UserId = "C00002CS0001", GroupSoccerFieldId = "C00002", Position = UserPostion.Owner.ToDescription() },

                new User_GroupSoccerField { UserId = "C00001NV0001", GroupSoccerFieldId = "C00001", Position = UserPostion.Manager.ToDescription() },
                new User_GroupSoccerField { UserId = "C00001NV0002", GroupSoccerFieldId = "C00001", Position = UserPostion.Seller.ToDescription() },
                new User_GroupSoccerField { UserId = "C00001NV0003", GroupSoccerFieldId = "C00001", Position = UserPostion.Seller.ToDescription() },
                new User_GroupSoccerField { UserId = "C00002NV0001", GroupSoccerFieldId = "C00002", Position = UserPostion.Seller.ToDescription() }
            };
        }
        public static IEnumerable<SoccerField> SoccerFieldData()
        {
            return new List<SoccerField>()
            {
                new SoccerField {Id = "C00001SAN001", GroupSoccerFieldId = "C00001", Size = 11, Kind = TypeGrass.Grass.ToDescription(),
                    IsEnable = true, Price = 180000, Note = "Bình thường" },
                new SoccerField {Id = "C00001SAN002", GroupSoccerFieldId = "C00001", Size = 7, Kind = TypeGrass.Artificial.ToDescription(),
                    IsEnable = true, Price = 90000, Note = "Bình thường" },
                new SoccerField {Id = "C00001SAN003", GroupSoccerFieldId = "C00001", Size = 11, Kind = TypeGrass.Grass.ToDescription(),
                    IsEnable = true, Price = 180000, Note = "Bình thường" },
                new SoccerField {Id = "C00001SAN004", GroupSoccerFieldId = "C00001", Size = 7, Kind = TypeGrass.Artificial.ToDescription(),
                    IsEnable = true, Price = 90000, Note = "Bình thường" },
                new SoccerField {Id = "C00001SAN005", GroupSoccerFieldId = "C00001", Size = 11, Kind = TypeGrass.Grass.ToDescription(),
                    IsEnable = false, Price = 180000, Note = "Đang sửa chữa" },
                new SoccerField {Id = "C00001SAN006", GroupSoccerFieldId = "C00001", Size = 7, Kind = TypeGrass.Artificial.ToDescription(),
                    IsEnable = true, Price = 90000, Note = "Bình thường" },
                new SoccerField {Id = "C00002SAN001", GroupSoccerFieldId = "C00002", Size = 11, Kind = TypeGrass.Grass.ToDescription(),
                    IsEnable = true, Price = 180000, Note = "Bình thường" },
                new SoccerField {Id = "C00002SAN002", GroupSoccerFieldId = "C00002", Size = 7, Kind = TypeGrass.Artificial.ToDescription(),
                    IsEnable = true, Price = 90000, Note = "Bình thường" },
                new SoccerField {Id = "C00002SAN003", GroupSoccerFieldId = "C00002", Size = 11, Kind = TypeGrass.Grass.ToDescription(),
                    IsEnable = true, Price = 180000, Note = "Bình thường" },
                new SoccerField {Id = "C00002SAN004", GroupSoccerFieldId = "C00002", Size = 7, Kind = TypeGrass.Artificial.ToDescription(),
                    IsEnable = true, Price = 90000, Note = "Bình thường" },
                new SoccerField {Id = "C00002SAN005", GroupSoccerFieldId = "C00002", Size = 11, Kind = TypeGrass.Grass.ToDescription(),
                    IsEnable = false, Price = 180000, Note = "Đang sửa chữa" },
                new SoccerField {Id = "C00002SAN006", GroupSoccerFieldId = "C00002", Size = 7, Kind = TypeGrass.Artificial.ToDescription(),
                    IsEnable = true, Price = 90000, Note = "Bình thường" },
            };
        }
        public static IEnumerable<Product> ProductData()
        {
            return new List<Product>()
            {
                new Product { Id = "C00001Ao0001", GroupSoccerFieldId = "C00001", Name = "Áo thun 1", Price = 15000,
                    Amount = 90, IsEnable = true, Note = "Đang bán" },
                new Product { Id = "C00001Ao0002", GroupSoccerFieldId = "C00001", Name = "Áo thun 2", Price = 10000,
                    Amount = 70, IsEnable = true, Note = "Đang bán" },
                new Product { Id = "C00001TraDaL", GroupSoccerFieldId = "C00001", Name = "Trà đá lớn", Price = 10000,
                    Amount = 90, IsEnable = true, Note = "Đang bán" },
                new Product { Id = "C00001TraDaN", GroupSoccerFieldId = "C00001", Name = "Trà đá nhỏ", Price = 6000,
                    Amount = 70, IsEnable = true, Note = "Đang bán" },
                new Product { Id = "C00001ColaLo", GroupSoccerFieldId = "C00001", Name = "Cocacola Lon", Price = 10000,
                    Amount = 70, IsEnable = true, Note = "Đang bán" },
                new Product { Id = "C00001ColaCh", GroupSoccerFieldId = "C00001", Name = "Cocacola Lon", Price = 8000,
                    Amount = 70, IsEnable = true, Note = "Đang bán" },
                new Product { Id = "C00002Ao0001", GroupSoccerFieldId = "C00002", Name = "Áo thun 1", Price = 15000,
                    Amount = 90, IsEnable = true, Note = "Đang bán" },
                new Product { Id = "C00002Ao0002", GroupSoccerFieldId = "C00002", Name = "Áo thun 2", Price = 10000,
                    Amount = 70, IsEnable = true, Note = "Đang bán" },
                new Product { Id = "C00002TraDaL", GroupSoccerFieldId = "C00002", Name = "Trà đá lớn", Price = 11000,
                    Amount = 90, IsEnable = true, Note = "Đang bán" },
                new Product { Id = "C00002TraDaN", GroupSoccerFieldId = "C00002", Name = "Trà đá nhỏ", Price = 7000,
                    Amount = 70, IsEnable = true, Note = "Đang bán" },
                new Product { Id = "C00002ColaLo", GroupSoccerFieldId = "C00002", Name = "Cocacola Lon", Price = 11000,
                    Amount = 70, IsEnable = true, Note = "Đang bán" },
                new Product { Id = "C00002ColaCh", GroupSoccerFieldId = "C00002", Name = "Cocacola Lon", Price = 9000,
                    Amount = 70, IsEnable = true, Note = "Đang bán" }
            };
        }
        public static IEnumerable<WorkScheduleStaff> WorkScheduleStaffData()
        {
            return new List<WorkScheduleStaff>()
            {
                new WorkScheduleStaff { StaffUserName = "C00001NV0001", Day = DateTime.ParseExact("20/05/2018", "dd/MM/yyyy", ci),
                    Shift = WorkingShifts.Morning.ToDescription(), Status = false, Note = "Chưa hoàn thành" },
                new WorkScheduleStaff { StaffUserName = "C00001NV0001", Day = DateTime.ParseExact("20/01/2019", "dd/MM/yyyy", ci),
                    Shift = WorkingShifts.Afternoon.ToDescription(), Status = true, Note = "Đã xong" },
                new WorkScheduleStaff { StaffUserName = "C00001NV0001", Day = DateTime.ParseExact("18/01/2019", "dd/MM/yyyy", ci),
                    Shift = WorkingShifts.Evening.ToDescription(), Status = false, Note = "Chưa hoàn thành" }
            };
        }
    }
}
