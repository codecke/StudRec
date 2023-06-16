using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudRec.Models
{
    [Table("dbmajors")]
    public class Major
    {
        [Key]
        public int MajorID { get; set; }
        public string DeptName { get; set; }
        public int FacultyID { get; set; }
    }
}
