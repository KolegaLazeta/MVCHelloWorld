using System.Web.Mvc;
using DataAccess;
using BusinessObjectModel;
using System.Linq;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web;
using System;
using System.Data.Entity;
using BusinessLayer;

namespace MvcAppHelloWorld.Controllers
{
    public class HomeController : Controller
    {
        private IGenericService<Users> _service;
        public HomeController(IGenericService<Users> service) 
        {
            _service = service;
        }
        public ActionResult Index()
        {
            if (!Request.IsAuthenticated)
                return View("Login");
            else
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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(BusinessObjectModel.Login login)
        {
            using (var db = new TuxContext())
            {
                var user = _service.GetList().FirstOrDefault(a => a.Email == login.Email && a.Password == login.Password);
                if (user != null)
                {
                    var Ticket = new FormsAuthenticationTicket(login.Email, true, 3000);
                    string Encrypt = FormsAuthentication.Encrypt(Ticket);
                    var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, Encrypt);
                    cookie.Expires = DateTime.Now.AddHours(3000);
                    cookie.HttpOnly = true;
                    Response.Cookies.Add(cookie);

                    if (user.UserRole.FirstOrDefault(ur => ur.Role.Name == "Admin") != null)
                        {
                            return RedirectToAction("Index", "Admin");
                        }

                    return RedirectToAction("Index", "User", user);
                }
                return View("Login");
            }
        }

    }
}