﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Validators
{
    public class PaymentHistoryViewModelValidator : AbstractValidator<PaymentHistoryViewModel>
    {
        public PaymentHistoryViewModelValidator()
        {
            RuleFor(x => x.Date).NotNull();
            RuleFor(x => x.Description).NotNull();
            RuleFor(x => x.Saldo).NotNull();
            RuleFor(x => x.UserName).NotNull();
            RuleFor(x => x.UserId).NotNull();
        }
    }
}
