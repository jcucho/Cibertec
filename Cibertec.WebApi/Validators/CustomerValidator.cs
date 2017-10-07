﻿using Cibertec.Models;
using FluentValidation;

namespace Cibertec.WebApi.Validators
{
    public class CustomerValidator: AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName).NotNull().NotEmpty().WithMessage("this field is required");
            RuleFor(x => x.LastName).NotNull().NotEmpty().WithMessage("this field is required");
            RuleFor(x => x.City).NotNull().NotEmpty().WithMessage("this field is required");
        }

    }
}