using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PoliginBase.Models;

namespace PoliginBase.Controllers
{
    public class ProblemController : Controller
    {
        private ProblemContext db = new ProblemContext();

        //
        // GET: /Problem/

        public ActionResult Index()
        {
            return View(db.Problems.ToList());
        }

        //
        // GET: /Problem/Details/5

        public ActionResult Details(int id = 0)
        {
            Problem problem = db.Problems.Find(id);
            if (problem == null)
            {
                return HttpNotFound();
            }
            return View(problem);
        }

        //
        // GET: /Problem/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Problem/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Problem problem)
        {
            if (ModelState.IsValid)
            {
                db.Problems.Add(problem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(problem);
        }

        //
        // GET: /Problem/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Problem problem = db.Problems.Find(id);
            if (problem == null)
            {
                return HttpNotFound();
            }
            return View(problem);
        }

        //
        // POST: /Problem/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Problem problem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(problem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(problem);
        }

        //
        // GET: /Problem/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Problem problem = db.Problems.Find(id);
            if (problem == null)
            {
                return HttpNotFound();
            }
            return View(problem);
        }

        //
        // POST: /Problem/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Problem problem = db.Problems.Find(id);
            db.Problems.Remove(problem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}