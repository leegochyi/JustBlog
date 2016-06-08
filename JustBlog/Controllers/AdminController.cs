using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JustBlog.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            if(User.Identity.IsAuthenticated)
            {
                if (!String.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    return Redirect(returnUrl);

                return RedirectToAction("Manage");
            }

            ViewBag.ReturnUrl = returnUrl;

            return View();
        }
    }
}