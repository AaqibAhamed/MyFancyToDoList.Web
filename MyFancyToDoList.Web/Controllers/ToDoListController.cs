using MyFancyToDoList.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MyFancyToDoList.Web.Controllers
{
    public class ToDoListController : Controller
    {
        private ToDoListDbContext db = new ToDoListDbContext();

        
        // GET: ToDoList
        public ActionResult Index()
        {
            return View(db.ToDoLists.ToList()); //Return the created lists 
        }
        public ActionResult TodayTask()
        {
            return View(db.ToDoLists.ToList());
            //have to implement 
        }

        public ActionResult WeekTask()
        {
            return View(db.ToDoLists.ToList());
            //have to implement 
        }

        // GET: ToDoList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDoList/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind. 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,DueDate,IsReOccuring")] ToDoList toDoList)
        {
            if(ModelState.IsValid)
            {
                db.ToDoLists.Add(toDoList);
                db.SaveChanges();
                return RedirectToAction("Index"); //After an item added return to index Action -List
            }

            return View(toDoList);
        }

        // GET: ToDoList/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);//if not exist
            }
            ToDoList toDoList = db.ToDoLists.Find(id);

            if (toDoList == null)
            {
                return HttpNotFound();
            }
            return View(toDoList);
        }

        // GET: ToDoList/Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToDoList toDoList = db.ToDoLists.Find(id);
            if (toDoList == null)
            {
                return HttpNotFound();
            }
            return View(toDoList);
        }

        // POST: ToDoList/Edit/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,DueDate,IsReOccuring")] ToDoList toDoList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(toDoList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");//After an item Edited return to index Action -List
            }
            return View(toDoList);
        }

        // GET: ToDoList/Delete/
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToDoList toDoList = db.ToDoLists.Find(id);
            if (toDoList == null)
            {
                return HttpNotFound();
            }
            return View(toDoList);
        }

        // POST: ToDoList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ToDoList toDoList  = db.ToDoLists.Find(id);
            db.ToDoLists.Remove(toDoList);
            db.SaveChanges();
            return RedirectToAction("Index");//After an item Deleted return to index Action -List
        }

        protected override void Dispose(bool disposing) 
        {
            if (disposing)       //	 Releases all resources that are used by the current instance of the Controller class.
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult Completed()
        {
            return View(db.ToDoLists.ToList()); //Have to implement
        }




    }
}