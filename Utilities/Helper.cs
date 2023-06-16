using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudRec.Utilities
{
    public static class Helper
    {
        public static List<SelectListItem> GenderList()
        {
            List<SelectListItem> Gender = new List<SelectListItem>();
            Gender.Add(new SelectListItem { Text = "Male", Value = "M" });
            Gender.Add(new SelectListItem { Text = "Female", Value = "F" });
            return Gender;
        }
    }
}
