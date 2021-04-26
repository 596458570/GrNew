using Gr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gr.Controllers
{
    public class PhbController : Controller
    {
        // GET: Phb
        public ActionResult Index(int pageIndex = 1, int pageSize =999)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
              
                var phb = db.phb.ToList();
                var res = db.phb
                    .OrderBy(p => p.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                ViewBag.pageIndex = pageIndex;
                ViewBag.pageSize = pageSize;
                //计算总数
                ViewBag.totalRows = phb.Count;
                //计算共有多少页
                ViewBag.totalPage = Math.Ceiling(phb.Count * 1.0 / pageSize);
                return View(res);
            }
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            //显示
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                List<phb> u = db.phb.Where(b => b.title.Contains(name) || b.name.Contains(name)).ToList();
                return View(u);
            }
        }


        /// <summary>
        /// 热搜榜
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ActionResult Rs(int pageIndex = 1, int pageSize = 999)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {

                var phb = db.phb.ToList();
                var res = db.phb
                    .OrderBy(p => p.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                ViewBag.pageIndex = pageIndex;
                ViewBag.pageSize = pageSize;
                //计算总数
                ViewBag.totalRows = phb.Count;
                //计算共有多少页
                ViewBag.totalPage = Math.Ceiling(phb.Count * 1.0 / pageSize);
                return View(res);
            }
        }
        [HttpPost]
        public ActionResult Rs(string name)
        {
            //显示
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                List<phb> u = db.phb.Where(b => b.title.Contains(name) || b.name.Contains(name)).ToList();
                return View(u);
            }
        }

        /// <summary>
        /// 热议榜
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult Ry(int pageIndex = 1, int pageSize = 999)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {

                var phb = db.phb.ToList();
                var res = db.phb
                    .OrderBy(p => p.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                ViewBag.pageIndex = pageIndex;
                ViewBag.pageSize = pageSize;
                //计算总数
                ViewBag.totalRows = phb.Count;
                //计算共有多少页
                ViewBag.totalPage = Math.Ceiling(phb.Count * 1.0 / pageSize);
                return View(res);
            }
        }
        [HttpPost]
        public ActionResult Ry(string name)
        {
            //显示
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                List<phb> u = db.phb.Where(b => b.title.Contains(name) || b.name.Contains(name)).ToList();
                return View(u);
            }
        }

        /// <summary>
        /// 影视榜
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult Ys(int pageIndex = 1, int pageSize = 999)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {

                var phb = db.phb.ToList();
                var res = db.phb
                    .OrderBy(p => p.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                ViewBag.pageIndex = pageIndex;
                ViewBag.pageSize = pageSize;
                //计算总数
                ViewBag.totalRows = phb.Count;
                //计算共有多少页
                ViewBag.totalPage = Math.Ceiling(phb.Count * 1.0 / pageSize);
                return View(res);
            }
        }
        [HttpPost]
        public ActionResult Ys(string name)
        {
            //显示
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                List<phb> u = db.phb.Where(b => b.title.Contains(name) || b.name.Contains(name)).ToList();
                return View(u);
            }
        }



        /// <summary>
        /// 音乐榜
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult Yy(int pageIndex = 1, int pageSize = 999)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {

                var phb = db.phb.ToList();
                var res = db.phb
                    .OrderBy(p => p.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                ViewBag.pageIndex = pageIndex;
                ViewBag.pageSize = pageSize;
                //计算总数
                ViewBag.totalRows = phb.Count;
                //计算共有多少页
                ViewBag.totalPage = Math.Ceiling(phb.Count * 1.0 / pageSize);
                return View(res);
            }
        }
        [HttpPost]
        public ActionResult Yy(string name)
        {
            //显示
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                List<phb> u = db.phb.Where(b => b.title.Contains(name) || b.name.Contains(name)).ToList();
                return View(u);
            }
        }


        /// <summary>
        /// 摄影榜
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult Sy(int pageIndex = 1, int pageSize = 999)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {

                var phb = db.phb.ToList();
                var res = db.phb
                    .OrderBy(p => p.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                ViewBag.pageIndex = pageIndex;
                ViewBag.pageSize = pageSize;
                //计算总数
                ViewBag.totalRows = phb.Count;
                //计算共有多少页
                ViewBag.totalPage = Math.Ceiling(phb.Count * 1.0 / pageSize);
                return View(res);
            }
        }
        [HttpPost]
        public ActionResult Sy(string name)
        {
            //显示
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                List<phb> u = db.phb.Where(b => b.title.Contains(name) || b.name.Contains(name)).ToList();
                return View(u);
            }
        }

        /// <summary>
        /// 设计榜
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult Sj(int pageIndex = 1, int pageSize = 999)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {

                var phb = db.phb.ToList();
                var res = db.phb
                    .OrderBy(p => p.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                ViewBag.pageIndex = pageIndex;
                ViewBag.pageSize = pageSize;
                //计算总数
                ViewBag.totalRows = phb.Count;
                //计算共有多少页
                ViewBag.totalPage = Math.Ceiling(phb.Count * 1.0 / pageSize);
                return View(res);
            }
        }
        [HttpPost]
        public ActionResult Sj(string name)
        {
            //显示
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                List<phb> u = db.phb.Where(b => b.title.Contains(name) || b.name.Contains(name)).ToList();
                return View(u);
            }
        }

        /// <summary>
        /// 财富榜
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult Cf(int pageIndex = 1, int pageSize = 999)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {

                var phb = db.phb.ToList();
                var res = db.phb
                    .OrderBy(p => p.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                ViewBag.pageIndex = pageIndex;
                ViewBag.pageSize = pageSize;
                //计算总数
                ViewBag.totalRows = phb.Count;
                //计算共有多少页
                ViewBag.totalPage = Math.Ceiling(phb.Count * 1.0 / pageSize);
                return View(res);
            }
        }
        [HttpPost]
        public ActionResult Cf(string name)
        {
            //显示
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                List<phb> u = db.phb.Where(b => b.title.Contains(name) || b.name.Contains(name)).ToList();
                return View(u);
            }
        }
        /// <summary>
        /// 产品
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult Cp(int pageIndex = 1, int pageSize = 999)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {

                var phb = db.phb.ToList();
                var res = db.phb
                    .OrderBy(p => p.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                ViewBag.pageIndex = pageIndex;
                ViewBag.pageSize = pageSize;
                //计算总数
                ViewBag.totalRows = phb.Count;
                //计算共有多少页
                ViewBag.totalPage = Math.Ceiling(phb.Count * 1.0 / pageSize);
                return View(res);
            }
        }
        [HttpPost]
        public ActionResult Cp(string name)
        {
            //显示
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                List<phb> u = db.phb.Where(b => b.title.Contains(name) || b.name.Contains(name)).ToList();
                return View(u);
            }
        }


        /// <summary>
        /// 游戏榜
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult Yx(int pageIndex = 1, int pageSize = 999)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {

                var phb = db.phb.ToList();
                var res = db.phb
                    .OrderBy(p => p.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                ViewBag.pageIndex = pageIndex;
                ViewBag.pageSize = pageSize;
                //计算总数
                ViewBag.totalRows = phb.Count;
                //计算共有多少页
                ViewBag.totalPage = Math.Ceiling(phb.Count * 1.0 / pageSize);
                return View(res);
            }
        }
        [HttpPost]
        public ActionResult Yx(string name)
        {
            //显示
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                List<phb> u = db.phb.Where(b => b.title.Contains(name) || b.name.Contains(name)).ToList();
                return View(u);
            }
        }

        /// <summary>
        /// 大数据
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult Ds(int pageIndex = 1, int pageSize = 999)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {

                var phb = db.phb.ToList();
                var res = db.phb
                    .OrderBy(p => p.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                ViewBag.pageIndex = pageIndex;
                ViewBag.pageSize = pageSize;
                //计算总数
                ViewBag.totalRows = phb.Count;
                //计算共有多少页
                ViewBag.totalPage = Math.Ceiling(phb.Count * 1.0 / pageSize);
                return View(res);
            }
        }
        [HttpPost]
        public ActionResult Ds(string name)
        {
            //显示
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                List<phb> u = db.phb.Where(b => b.title.Contains(name) || b.name.Contains(name)).ToList();
                return View(u);
            }
        }


        /// <summary>
        /// 其他榜
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult Qt(int pageIndex = 1, int pageSize = 999)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {

                var phb = db.phb.ToList();
                var res = db.phb
                    .OrderBy(p => p.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                ViewBag.pageIndex = pageIndex;
                ViewBag.pageSize = pageSize;
                //计算总数
                ViewBag.totalRows = phb.Count;
                //计算共有多少页
                ViewBag.totalPage = Math.Ceiling(phb.Count * 1.0 / pageSize);
                return View(res);
            }
        }
        [HttpPost]
        public ActionResult Qt(string name)
        {
            //显示
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                List<phb> u = db.phb.Where(b => b.title.Contains(name) || b.name.Contains(name)).ToList();
                return View(u);
            }
        }

    }
}