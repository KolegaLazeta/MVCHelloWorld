using BusinessLayer;
using BusinessObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcAppHelloWorld.Controllers
{
    public class LoginController : Controller
    {
        private IGenericAppService<UsersViewModel, Users> _service;
        public LoginController(IGenericAppService<UsersViewModel, Users> service)
        {
            _service = service;
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login login)
        {
            
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
                        return RedirectToAction("Index", "Admin", user);
                    }

                    return RedirectToAction("Index", "User", user);
                }
                return View("Login");
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}