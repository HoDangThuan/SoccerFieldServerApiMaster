using System;
using System.ComponentModel.DataAnnotations;

namespace SoccerFieldServer.Core.Entities
{
    public class GroupSoccerField
    {
        [Key]
        [StringLength(6)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
        public double Latlng_latitude { get; set; }
        public double Latlng_longitude { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
        public double PercentVAT { get; set; }
        public double PercentPunish { get; set; }
        public double PercentRushHour { get; set; }
        public bool IsEnable { get; set; }
        public string Note { get; set; }
    }
}