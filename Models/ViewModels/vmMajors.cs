using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudRec.Models.ViewModels
{
    public class vmMajors
    {
        public int MajorID { get; set; }
        [DisplayName("Department")]
        public string DeptName { get; set; }
        [DisplayName("Faculty")]
        public int FacultyID { get; set; }
        [ForeignKey("FacultyID")]
        public virtual Faculty faculty { get; set; }
    }
}
