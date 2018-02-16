using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class CustomerMapCodes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerMapCodeID { get; set; }
        public string CustomerMapCodeName { get; set; }
    }
}
