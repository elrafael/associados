using Associados.Core;
using Associados.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Associados.Web.Controllers
{
    public class LoginController : Controller
    {
        private UserRepository db = new UserRepository();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            bool login = db.login(user.Username, user.Password);

            string message = String.Empty;

            if ( login )
            {
                FormsAuthentication.SetAuthCookie(user.Username, user.RememberMe);
                return Redirect("Associados");
            } else
            {
                message = "Erro no login";
            }

            ViewBag.message = message;

            return View();
        }
    }
}