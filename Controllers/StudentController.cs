using Microsoft.AspNetCore.Mvc;
using StudRec.Data;
using StudRec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudRec.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudRecContext _db;

        public IActionResult Index()
        {
            var fac = _db.StudInfos.ToList();

            return View(fac);
        }
        public IActionResult getStudentInfo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult getStudentInfo(Studinfo fac)
        {
            if (ModelState.IsValid)
            {
                _db.StudInfos.Add(fac);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
