using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerFieldServer.Core.Entities
{
    public class CustomerHistory
    {
        [Key, Column(Order = 0)]
        [StringLength(12)]
        //Foreign key for Customer
        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }

        [Key, Column(Order = 1)]
        [StringLength(12)]
        //Foreign key for BookField
        public string BookFieldId { get; set; }
        public BookField BookField { get; set; }

        public string Note { get; set; }
    }
}