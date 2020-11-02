using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_Practice.Models;

namespace CRUD_Practice.Controllers
{
    public class HomeController : Controller
    {

        StudentContext db = new StudentContext();
        // GET: Home
        public ActionResult Index()
        {
            // Fetching all the rows of Students object from the Student Model class and converting into List() 
            // and set it to the variable 'data' and then passed 'data' to the view.
            var data = db.Students.ToList();

            return View(data);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid == true)
            {
                // All the Student data as 's' is added to the 'Students' table
                // and Saving it to database by the help of StudentContext class's object 'db'
                db.Students.Add(s);
                // SaveChanges() method returns 1 if success and 0 if unsuccess
                if (db.SaveChanges() > 0)
                {
                    // ViewBag.InsertMessage = "Data Inserted!!";
                    // Clear the ModelState (Fields of the form)
                    // ModelState.Clear();

                    // Tempdata is used since Data transfer from View to View
                    TempData["InsertMessage"] = "Data Inserted!!";
                    return RedirectToAction("Index");
                }
                else
                    ViewBag.InsertMessage = "<script>alert('Data not Insertede!!!)</script>";
            }

            return View();
        }

        public ActionResult Edit(int id)
        {
            var row = db.Students.Where(model => model.Id == id).FirstOrDefault();

            return View(row);
        }
        
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            db.Entry(s).State = EntityState.Modified;
            if (db.SaveChanges() > 0)
            {
                // ViewBag.UpdateMessage = "Data Updated!!";
                // ModelState.Clear();
                TempData["UpdateMessage"] = "Data Updated!!";
                return RedirectToAction("Index");
            }
            else
                ViewBag.UpdateMessage = "Something went wrong!!!";

            return View();
        }

        public ActionResult Delete(int id)
        {
            var StudentToDelete = db.Students.Where(model => model.Id == id).FirstOrDefault();
            return View(StudentToDelete);
        }

        [HttpPost]
        public ActionResult Delete(Student s)
        {
            db.Entry(s).State = EntityState.Deleted;
            if (db.SaveChanges() > 0)
            {
                TempData["DeleteMessage"] = "Data has been Deleted Succesfully!!";
                return RedirectToAction("Index");
            }
            else
                TempData["DeleteMessage"] = "Something went wrong!!!";

            return View();
        }
    }
}