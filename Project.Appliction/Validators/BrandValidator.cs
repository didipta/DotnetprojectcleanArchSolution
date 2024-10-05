﻿using FluentValidation;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Appliction.Validators
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Name)
                .NotEmpty().WithMessage("Brand name is required.")
                .Length(2, 50).WithMessage("Brand name must be between 2 and 50 characters.");
        }
    }
}
