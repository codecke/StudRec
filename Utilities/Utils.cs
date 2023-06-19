using StudRec.Data;
using StudRec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudRec.Utilities
{

    public class utils
    {
        private StudRecContext _dc;

        public utils(StudRecContext dc)
        {
            _dc = dc;
        }
        public List<Faculty> getFaculty()
        {
            List<Faculty> FacultyList = new List<Faculty>();
            FacultyList = _dc.Faculties.ToList();
            FacultyList.Insert(0, new Faculty { FacultyID = 0, FacultyName = "Select..." });
            return FacultyList;
        }

        public List<Major> getDepartments()
        {
            var DeptList = _dc.Majors.ToList();
        }
    }
}
