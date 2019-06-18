using SuperCaptcha.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvctest.Models
{
    public class Test
    {
        public string CouponCode { get; set; }
        public bool b { get; internal set; }

        [Required(ErrorMessage = "Captcha is required")]
        [VerifyCaptcha]
        public string CaptchaText { get; set; }
    }
}