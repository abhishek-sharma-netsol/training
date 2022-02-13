using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SecondAssignment.Models;

namespace SecondAssignment.Controllers
{
    public class StudentController : Controller
    {
          List<Student> studentList = new List<Student>() {
            new Student() { Id = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male", Age = 21}
          };

        // GET: Student
        public ActionResult Index()
        {
          return View(studentList);
        }

        // GET: Student/Details/5 
        public ActionResult Details(int id)
        {
          Student result = studentList.Find(x => x.Id == id);
          return View(result);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
          Student formData = new Student() { Id = Int32.Parse(collection["Id"]), Name = collection["Name"], Branch = collection["Branch"], Section = collection["Section"], Gender = collection["Gender"], Age = Int32.Parse(collection["Age"]) };
          studentList.Add(formData);
          return View("Index", studentList);
          //return RedirectToAction(nameof(Index), studentList);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
          Student result = studentList.Find(x => x.Id == id);
          ViewBag.Student= result;
          return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
              studentList.Find(p => p.Id == id).Name = collection["Name"];
              studentList.Find(p => p.Id == id).Branch = collection["Branch"];
              studentList.Find(p => p.Id == id).Section = collection["Section"];
              studentList.Find(p => p.Id == id).Gender = collection["Gender"];
              studentList.Find(p => p.Id == id).Age = Int32.Parse(collection["Age"]);
              //Student formData = new Student() { Id = id, Name = collection["Name"], Branch = collection["Branch"], Section = collection["Section"], Gender = collection["Gender"], Age = Int32.Parse(collection["Age"]) };
              //studentList.Add(formData);
              return View("Index", studentList);
              //return RedirectToAction(nameof(Index));
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
          var itemToRemove = studentList.Find(r => r.Id == id);
          studentList.Remove(itemToRemove);
            return View("Index", studentList);
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
