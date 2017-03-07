using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Parth.Models;

namespace Parth.Controllers
{
    public class OverviewsController : Controller
    {
        private OverviewContext db = new OverviewContext();

        // GET: Overviews
        public ActionResult Index()
        {
            var overviews = db.Overviews.Include(o => o.department).Include(o => o.employee).Include(o => o.hardware).Include(o => o.software);
            return View(overviews.ToList());
        }

        // GET: Overviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Overview overview = db.Overviews.Find(id);
            if (overview == null)
            {
                return HttpNotFound();
            }
            return View(overview);
        }

        // GET: Overviews/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "DepartmenteName");
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "EmployeeName");
            ViewBag.HardwareId = new SelectList(db.Hardwares, "HardwareId", "Model");
            ViewBag.SoftwareId = new SelectList(db.Softwares, "SoftwareId", "SoftwareName");
            return View();
        }

        // POST: Overviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OverviewId,EmployeeId,HardwareId,SoftwareId,DepartmentId,ManagerName")] Overview overview)
        {
            if (ModelState.IsValid)
            {
                db.Overviews.Add(overview);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "DepartmenteName", overview.DepartmentId);
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "EmployeeName", overview.EmployeeId);
            ViewBag.HardwareId = new SelectList(db.Hardwares, "HardwareId", "Model", overview.HardwareId);
            ViewBag.SoftwareId = new SelectList(db.Softwares, "SoftwareId", "SoftwareName", overview.SoftwareId);
            return View(overview);
        }

        // GET: Overviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Overview overview = db.Overviews.Find(id);
            if (overview == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "DepartmenteName", overview.DepartmentId);
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "EmployeeName", overview.EmployeeId);
            ViewBag.HardwareId = new SelectList(db.Hardwares, "HardwareId", "Model", overview.HardwareId);
            ViewBag.SoftwareId = new SelectList(db.Softwares, "SoftwareId", "SoftwareName", overview.SoftwareId);
            return View(overview);
        }

        // POST: Overviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OverviewId,EmployeeId,HardwareId,SoftwareId,DepartmentId,ManagerName")] Overview overview)
        {
            if (ModelState.IsValid)
            {
                db.Entry(overview).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "DepartmenteName", overview.DepartmentId);
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "EmployeeName", overview.EmployeeId);
            ViewBag.HardwareId = new SelectList(db.Hardwares, "HardwareId", "Model", overview.HardwareId);
            ViewBag.SoftwareId = new SelectList(db.Softwares, "SoftwareId", "SoftwareName", overview.SoftwareId);
            return View(overview);
        }

        // GET: Overviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Overview overview = db.Overviews.Find(id);
            if (overview == null)
            {
                return HttpNotFound();
            }
            return View(overview);
        }

        // POST: Overviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Overview overview = db.Overviews.Find(id);
            db.Overviews.Remove(overview);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
