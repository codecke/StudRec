using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudRec.Models
{
    [Table("dbFaculty")]
    public class Faculty
    {
        [Key]
        public int FacultyID { get; set; }
        [DisplayName("Faculty Name")]
        public String FacultyName { get; set; }
    }
}
