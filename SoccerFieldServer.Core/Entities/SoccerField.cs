using SoccerFieldServer.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SoccerFieldServer.Core.Entities
{
    public class SoccerField
    {
        [Key]
        [StringLength(12)]
        public string Id { get; set; }

        public int Size { get; set; }
        public string Kind { get; set; }
        public decimal Price { get; set; }
        public bool IsEnable { get; set; }
        public string Note { get; set; }

        [Required]
        [StringLength(6)]
        public string GroupSoccerFieldId { get; set; }
        public GroupSoccerField GroupSoccerField { get; set; }
    }
}
