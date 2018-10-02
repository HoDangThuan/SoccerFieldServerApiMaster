using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerFieldServer.Core.Entities
{
    public class DetailsOfBookField
    {
        [Key, Column(Order = 0)]
        [StringLength(12)]
        public string BookFieldId { get; set; }
        public BookField BookField { get; set; }

        [Key, Column(Order = 1)]
        [StringLength(12)]
        public string ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        [StringLength(12)]
        public string BillerId { get; set; }
        public ApplicationUser Biller { get; set; }

        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Fee { get; set; }
    }
}
