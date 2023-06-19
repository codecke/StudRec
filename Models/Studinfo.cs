using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudRec.Models
{
    [Table("dbStudInfo")]
    public class Studinfo
    {
        [Key]
        public int StudID { get; set; }
        public string MatNo { get; set; }
        public string  fname { get; set; }
        public string sname { get; set; }
        public DateTime DOB { get; set; }
        public int MyProperty { get; set; }
        public char Gender { get; set; }
        public int Major { get; set; }
        public int Faculty { get; set; }
    }
}
