using FluentValidation.Results;
using mvctest.Models;
using mvctest.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvctest.Controllers
{
    public class TestController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            var account = new Test();
            return View("Index", account);
        }

       
        public ActionResult App(Test account)
        {

            //validate my data

            TestValidator validator = new TestValidator();
            ValidationResult result = validator.Validate(account);
            int time;
            if (Session["time"] == null)
            {
                time = 0;
                Session["time"] = time;
                return View("App", account);
            }

            time = (int)Session["time"];

            Session["time"] = time + 1;


            if (result.IsValid == false)
            {
                if (time >= 3)
                {
                    // Show the captcha.
                    account.b = true;
                    ViewBag.ErrMessage = "Invalid Captcha";
                    return View("App", account);
                }

                else
                {
                    ViewBag.Err = "Invalid CouponCode";
                    return View("App", account);
                }
            }

            else
            {
                return View("Success", account);
            }


            /*     if (count <= 3)
             {
                 count=count +1;

                 ViewBag.error = "Invalid CouponCode";
                 return View("Index", account);
             }
             else
             {

                 return View("captcha",account);
             }
         }

         else
         {
             ViewBag.account = account;
             return View("Success");
         }
     }

*/
            /* public ActionResult Check(Account acc)
                 {


                     if (!this.IsCaptchaValid(""))
                     {
                         ViewBag.error = "Invalid Captcha";
                         return View("captcha", acc);
                     }
                     else
                     {
                         ViewBag.account = acc;
                         return View("Success");

                     }
                 }*/


        }


    }
}