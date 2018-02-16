using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("PP_BusinessUnits")]
    public class BusinessUnits
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessUnitID { get; set; }
        public string BusinessUnitName { get; set; }
        public string BusinessUnitDesc { get; set; }
    }
}
