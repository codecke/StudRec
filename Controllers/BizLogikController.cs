using Microsoft.AspNetCore.Mvc;
using StudRec.Data;
using StudRec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudRec.Controllers
{
    public class BizLogikController : Controller
    {
        private readonly StudRecContext _db;
        public BizLogikController(StudRecContext db)
        {
            _db = db;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult CreateFaculty()
        {
            var fac = _db.Faculties.ToList();
            return View(fac);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateFaculty(Faculty fac)
        {
            if (ModelState.IsValid)
            {
                _db.Faculties.Add(fac);
                _db.SaveChanges();
                return RedirectToAction(nameof (CreateFaculty));
            }
            return View();
        }
    }
}
