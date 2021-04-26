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
    public class SqwzsController : Controller
    {
        private HRMSDBEntities db = new HRMSDBEntities();

        // GET: Sqwzs
        public ActionResult Index()
        {
            return View(db.Sqwz.ToList());
        }

        // GET: Sqwzs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sqwz sqwz = db.Sqwz.Find(id);
            if (sqwz == null)
            {
                return HttpNotFound();
            }
            return View(sqwz);
        }

        // GET: Sqwzs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sqwzs/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,url,name,descs,cjdate")] Sqwz sqwz)
        {
            if (ModelState.IsValid)
            {
                db.Sqwz.Add(sqwz);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sqwz);
        }

        // GET: Sqwzs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sqwz sqwz = db.Sqwz.Find(id);
            if (sqwz == null)
            {
                return HttpNotFound();
            }
            return View(sqwz);
        }

        // POST: Sqwzs/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,url,name,descs,cjdate")] Sqwz sqwz)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sqwz).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sqwz);
        }

        // GET: Sqwzs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sqwz sqwz = db.Sqwz.Find(id);
            if (sqwz == null)
            {
                return HttpNotFound();
            }
            return View(sqwz);
        }

        // POST: Sqwzs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sqwz sqwz = db.Sqwz.Find(id);
            db.Sqwz.Remove(sqwz);
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
