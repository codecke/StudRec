using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudRec.Data;
using StudRec.Models;
using StudRec.Models.ViewModels;
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

            public BizLogikController(StudRecContext db, )
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

        public IActionResult AddNewFaculty()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNewFaculty(Faculty fac)
        {
            if (ModelState.IsValid)
            {
                _db.Faculties.Add(fac);
                _db.SaveChanges();
                return RedirectToAction(nameof (CreateFaculty));
            }
            return View();
        }

        public IActionResult ShowMajors()
        {
            //return View(_db.Majors.ToList());
            return View(getDepts());
        }

        public IActionResult NewMajor()
        {
            ViewBag.fac  = getFaculty().ToList();
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult NewMajor(Major obj)
        {
            if (ModelState.IsValid)
            {
                _db.Majors.Add(obj);
                _db.SaveChanges();
                return RedirectToAction(nameof(ShowMajors));

            }
            return View(obj);
        }
        public List<Faculty> getFaculty()
        {
            var FacultyList = _db.Faculties.ToList();
            FacultyList.Insert(0, new Faculty { FacultyID = 0, FacultyName = "Select..." });
            return FacultyList;
        }

        public List<vmMajors> getDepts()
        {
            var depts = (from dep in _db.Majors
                         join fac in _db.Faculties on dep.FacultyID equals fac.FacultyID into temp
                         from
fac in temp.DefaultIfEmpty()
                         select new vmMajors
                         {
                             MajorID = dep.MajorID,
                             DeptName = dep.DeptName,
                             FacultyID = dep.FacultyID,
                             faculty = fac

                         }

                         ).ToList();
            return depts;
        }
    }
}
