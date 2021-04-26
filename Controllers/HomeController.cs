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
using System.Web.Mail;
using System.Text;

namespace Gr.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Account, string Possword, string urole)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                Admin admin = db.Admin.FirstOrDefault(a => a.Account == Account && a.Possword == Possword);
                if (admin != null)
                {
                    Session["LoginID"] = admin.Id;
                    Session["LoginName"] = admin.Account;
                    Session["Dept"] = "尊敬";
                    Session["Type"] = "用户";
                    return Redirect("/sqwzs/index");
                }
                ModelState.AddModelError("", "账号或密码错误");
                return View();
            }
        }

       /// <summary>
       /// 注册
       /// </summary>
       /// <returns></returns>
        public ActionResult Register() {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Admin admin,string Account) {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                if (db.Admin.Any(x => x.Account == Account))
                {
                    //账号已被注册
                    return Content("<script>alert('账号已存在，是否忘记密码或输入错误');window.location.href='Login';</script>");
                }
                else
                {
                    db.Admin.Add(admin);
                    db.SaveChanges();
                    return Content("<script>alert('OK');window.location.href='Login';</script>");
                    //return RedirectToAction("Login");
                }

            }
        }


        public ActionResult WjPwd() {
            return View();
        }


         /// 提交忘记密码内容
       /// </summary>
       /// <param name="email"></param>
       /// <returns></returns>
        [HttpPost]
        [Obsolete]
        public ActionResult WjPwd(string email,string Account)
       {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {



                 if (db.Admin.Any(x => x.Account == Account))
                {
                    System.Web.Mail.MailMessage mmsg = new System.Web.Mail.MailMessage();
                    //邮件主题
                    mmsg.Subject = "主题";
                    mmsg.BodyFormat = MailFormat.Html;
                    Random r = new Random();
                    int i = r.Next(1000, 9999);
                    //邮件正文
                    mmsg.Body = "验证码为：" + i;
                    //正文编码
                    mmsg.BodyEncoding = Encoding.UTF8;
                    //优先级
                    mmsg.Priority = System.Web.Mail.MailPriority.High;
                    //发件者邮箱地址
                    mmsg.From = "Kevin596458570@163.com";
                    //收件人收箱地址
                    mmsg.To = Account;
                    mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
                    //用户名
                    mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "kevin");
                    //密码
                    mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "CPRDMIPEHYOVEXJG");
                    //端口 
                    mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", 465);
                    //使用SSL mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");
                    //Smtp服务器
                    System.Web.Mail.SmtpMail.SmtpServer = "smtp.163.com";
                    SmtpMail.Send(mmsg);
                    string ceod = i.ToString();
                    var entity = db.Admin.SingleOrDefault(x => x.Account == Account);
                    if (entity != null)
                    {
                        entity.Coed = ceod;
                    }
                    db.SaveChanges();
                    return Content("<script>alert('验证码以发送至您的邮箱，请您注意查收');window.location.href='WjPwd';</script>");
                }
                else
                {
                    //不存在，提示账号不存在
                    return Content("<script>alert('账号不存在，请查看是否输入错误或者重新注册');window.location.href='WjPwd';</script>");
                }




                //首先判断账号是否存在
                //if (db.Admin.Any(x => x.Account == Account))
                //{

                //    //如果存在，发送邮件
                //    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                //    message.From = new MailAddress("Kevin596458570@163.com", "Kevin");//发件人地址
                //    message.To.Add(Account);//目标发件地址
                //    message.Subject = "Kevin";//邮件标题
                //    //生成随机数
                //    Random r = new Random();
                //    int i = r.Next(1000, 9999);
                //    message.Body = "验证码为：" + i;//邮件内容
                //    SmtpClient smtp = new SmtpClient("smtp.163.com"); //发送邮件的smtp服务器地址
                //    smtp.Credentials = new NetworkCredential("Kevin596458570@163.com", "CPRDMIPEHYOVEXJG");//发件人的用户名和密码
                //    smtp.Send(message);

                //    string ceod = i.ToString();
                //    var entity = db.Admin.SingleOrDefault(x => x.Account == Account);
                //    if (entity != null)
                //    {
                //        entity.Coed = ceod;
                //    }
                //    db.SaveChanges();
                //    return Content("<script>alert('验证码以发送至您的邮箱，请您注意查收');window.location.href='WjPwd';</script>");
                //}
                //else
                //{
                //    //不存在，提示账号不存在
                //    return Content("<script>alert('账号不存在，请查看是否输入错误或者重新注册');window.location.href='WjPwd';</script>");
                //}

            }
               
       }

        //修改密码界面
        public ActionResult EditPwd(int id) 
        {
            return View();  
        }

        [HttpPost]
        public ActionResult EditPwd(Admin admin, string Account,string Possword, string QPossword, string Coed)
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                //验证码
                if (db.Admin.Any(x => x.Coed != Coed))
                {
                    return Content("<script>alert('验证码错误，请核对后重新输入');window.location.href='EditPwd';</script>");
                }

                if (Possword!=QPossword)
                {
                    return Content("<script>alert('两次输入的密码不一致');window.location.href='EditPwd';</script>");

                }
                var entity = db.Admin.SingleOrDefault(x => x.Account == Account);
                if (entity != null)
                {
                    entity.Possword = Possword;
                }
                db.SaveChanges();
                return Content("<script>alert('修改密码成功');window.location.href='Login';</script>");
            }
        }

       public ActionResult Default() 
       {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                //return db.Users.SingleOrDefault(u => u.UserId == id);
            }
            return View();
       }




        /// <summary>
        /// 留言板
        /// </summary>
        /// <returns></returns>
        public ActionResult Lyb()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lyb(Lyb lyb)
        {
            string clientIP = Request.UserHostAddress;
            using (HRMSDBEntities db = new HRMSDBEntities())
            {

                db.Lyb.Add(lyb);
                db.SaveChanges();
                return Content("<script>alert('留言成功');window.location.href='Lyb';</script>");
                //return RedirectToAction("Login");


            }
        }
       static  HRMSDBEntities d = new HRMSDBEntities();
       int con = d.Djt.Count();
        public ActionResult Djt()
        {
            using (HRMSDBEntities db = new HRMSDBEntities())
            {
                Random num = new Random();
                //暂时写死
                int rad = num.Next(1, 37);
                List<Djt> djts = db.Djt.Where(b=>b.newid==rad).ToList();
                return View(djts);

            }
        }

       

    }
}