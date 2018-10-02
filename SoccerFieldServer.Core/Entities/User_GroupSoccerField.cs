using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerFieldServer.Core.Entities
{
    public class User_GroupSoccerField
    {
        [Key]
        [StringLength(12)]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [StringLength(12)]
        public string GroupSoccerFieldId { get; set; }
        public GroupSoccerField GroupSoccerField { get; set; }

        public string Position { get; set; }
    }
}
