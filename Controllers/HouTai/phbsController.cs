using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Gr.Models;

namespace Gr.Controllers.HouTai
{
    public class phbsController : Controller
    {
        private HRMSDBEntities db = new HRMSDBEntities();

        // GET: phbs
        public ActionResult Index()
        {
            return View(db.phb.ToList());
        }

        // GET: phbs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phb phb = db.phb.Find(id);
            if (phb == null)
            {
                return HttpNotFound();
            }
            return View(phb);
        }

        // GET: phbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: phbs/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,url,name,img,title")] phb phb)
        {
            if (ModelState.IsValid)
            {
                db.phb.Add(phb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(phb);
        }

        // GET: phbs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phb phb = db.phb.Find(id);
            if (phb == null)
            {
                return HttpNotFound();
            }
            return View(phb);
        }

        // POST: phbs/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,url,name,img,title")] phb phb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phb);
        }

        // GET: phbs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phb phb = db.phb.Find(id);
            if (phb == null)
            {
                return HttpNotFound();
            }
            return View(phb);
        }

        // POST: phbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            phb phb = db.phb.Find(id);
            db.phb.Remove(phb);
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
