﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class TaskCategories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskCategoryID { get; set; }
        public string TaskCategoryName { get; set; }
        public string TaskCategoryDesc { get; set; }
    }
}
