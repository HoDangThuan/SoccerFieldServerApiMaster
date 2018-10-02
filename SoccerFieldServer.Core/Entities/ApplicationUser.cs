using Microsoft.AspNetCore.Identity;
using SoccerFieldServer.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerFieldServer.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsEnabled { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string BankAcount { get; set; }
        public string Sex { get; set; }
        public string Note { get; set; }
    }
}
