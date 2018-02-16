using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("PP_Projects")]
    public class Projects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }
        public int BusinessUnitID { get; set; }
        public int DivisionID { get; set; }
        public int TaskCategoryID { get; set; }
        public int TaskID { get; set; }
        public int TaskNumber { get; set; }
        public int CustomerCentricScore { get; set; }
        public int[] CustomerMapCodes { get; set; }
        public string Description { get; set; }
        public string Deliverable { get; set; }
        public int[] KeyContacts { get; set; }
        public System.DateTime DateStarted { get; set; }
        public System.DateTime DateEnded { get; set; }
        public bool IsChangedEndDate { get; set; }
        public System.DateTime DatePrevEnded { get; set; }
        public int StatusID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public int OwnerID { get; set; }
        public string[] Comments { get; set; }


    }
}
