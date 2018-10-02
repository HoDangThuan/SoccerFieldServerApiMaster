using SoccerFieldServer.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerFieldServer.Core.Entities
{
    public class WorkScheduleStaff
    {
        [Key, Column(Order = 0)]
        [StringLength(12)]
        public string StaffUserName { get; set; }
        public ApplicationUser Staff { get; set; }

        [Key, Column(Order = 1, TypeName = "date")]
        public DateTime Day { get; set; }

        [Key, Column(Order = 2)]
        public string Shift { get; set; }

        public bool Status { get; set; }
        public string Note { get; set; }
    }
}
