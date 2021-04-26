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
    public class DjtsController : Controller
    {
        private HRMSDBEntities db = new HRMSDBEntities();

        // GET: Djts
        public ActionResult Index()
        {
            return View(db.Djt.ToList());
        }

        // GET: Djts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Djt djt = db.Djt.Find(id);
            if (djt == null)
            {
                return HttpNotFound();
            }
            return View(djt);
        }

        // GET: Djts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Djts/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,djts,newid,color")] Djt djt)
        {
            if (ModelState.IsValid)
            {
                db.Djt.Add(djt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(djt);
        }

        // GET: Djts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Djt djt = db.Djt.Find(id);
            if (djt == null)
            {
                return HttpNotFound();
            }
            return View(djt);
        }

        // POST: Djts/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,djts,newid,color")] Djt djt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(djt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(djt);
        }

        // GET: Djts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Djt djt = db.Djt.Find(id);
            if (djt == null)
            {
                return HttpNotFound();
            }
            return View(djt);
        }

        // POST: Djts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Djt djt = db.Djt.Find(id);
            db.Djt.Remove(djt);
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
