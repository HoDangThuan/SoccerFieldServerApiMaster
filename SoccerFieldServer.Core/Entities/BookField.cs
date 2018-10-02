using System;
using System.ComponentModel.DataAnnotations;

namespace SoccerFieldServer.Core.Entities
{
    public class BookField
    {
        [Key]
        [StringLength(12)]
        public string Id { get; set; }

        [Required]
        [StringLength(6)]
        public string GroupSoccerFieldId { get; set; }
        public GroupSoccerField GroupSoccerField { get; set; }

        [Required]
        [StringLength(12)]
        public string SoccerFieldId { get; set; }
        public SoccerField SoccerField { get; set; }

        [Required]
        [StringLength(12)]
        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }

        [Required]
        [StringLength(12)]
        public string StaffId { get; set; }
        public ApplicationUser Staff { get; set; }

        [StringLength(12)]
        public string BillerId { get; set; }
        public ApplicationUser Biller { get; set; }

        [Required]
        public DateTime DayOfActionBookField { get; set; }
        [Required]
        public DateTime DayOfBookField { get; set; }
        [Required]
        public TimeSpan TimeStart { get; set; }
        [Required]
        public TimeSpan TimeEnd { get; set; }


        public DateTime? DayOfBill { get; set; }
        public decimal? BookFieldFee { get; set; }
        public decimal? ProductFee { get; set; }
        public decimal? ChangeFee { get; set; }
        public decimal? VatFee { get; set; }
        public decimal? TotalFee { get; set; }
        public bool Status { get; set; }
        public string Note { get; set; }
    }
}
