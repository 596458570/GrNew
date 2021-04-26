using Gr.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Gr.Controllers
{
    public class SqwzController : Controller
    {

        // GET: Sqwz
        public ActionResult Index(int pageIndex = 1, int pageSize = 999)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                var sqwz = db.Sqwz.ToList();
                var res = db.Sqwz
                    .OrderBy(p => p.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                ViewBag.pageIndex = pageIndex;
                ViewBag.pageSize = pageSize;
                //计算总数
                ViewBag.totalRows = sqwz.Count;
                //计算共有多少页
                ViewBag.totalPage = Math.Ceiling(sqwz.Count * 1.0 / pageSize);
                return View(res);
            }
        }

        [HttpPost]
        public ActionResult Index(string descs)
        {
            //显示
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                List<Sqwz> u = db.Sqwz.Where(b => b.descs.Contains(descs) || b.name.Contains(descs)).ToList();
                return View(u);
            }
        }
    }
}