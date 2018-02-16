using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class CustomerCentricScores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerCentricScoreID { get; set; }
        public int CustomerCentricScoreName { get; set; }
    }
}
