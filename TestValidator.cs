using FluentValidation;
using mvctest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvctest.Validator
{
    public class TestValidator : AbstractValidator<Test>
    {
        public TestValidator()

        {

            //RuleFor(x => x.CouponCode).NotEmpty().WithMessage("Coupon Code is required");
            RuleFor(x => x.CouponCode).Equal("ABCD");
        }
    }
}