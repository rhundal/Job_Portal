using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobPortal_JKIT.Models;

namespace JobPortal_JKIT.Views.Account
{
    [Authorize]
    public class AccountController : Controller
    {
        
        // GET: Account Controller for Get Register Page
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Register()      
        {
            return View();
        }

        // Post: Account Controller to Post To Register Page
        
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Employer emp)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Register", "Account");
            }

            return View("CreateEmpProfile");
        }
        

        // GET: Account Controller for Get Register JS Page
        [AllowAnonymous]
        [HttpGet]
        public ActionResult RegisterJS()
        {
            return View();
        }

        // Post: Account Controller to Post To Register JS Page
        /*
        [HttpPost]
        public ActionResult RegisterJS()
        {
            return View();
        }
         * */

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        /*
        [HttpPost]
        public ActionResult Login(JobSeekerProfile jsp)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("RegisterJS", "Account");
            }

            return View("CreateEmpProfile");    // return HomeProfile of Job Seeker 
        }
        */
        [AllowAnonymous]
        [HttpGet]
        public ActionResult ELogin()
        {
            return View();
        }

        /*
        [HttpPost]
        public ActionResult ELogin(Employer emp)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Register", "Account");
            }

            return View("CreateEmpProfile");    // return HomeProfile of Job Seeker 
        }
        */
    }
}