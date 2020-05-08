using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MVCAngular.Business.Entities;
using System.Configuration;
using MVCAngular.Interfaces;

namespace MVCAngular.Business
{
    public class ProductBusinessRules : AbstractValidator<Product>
    {
      
        public ProductBusinessRules()
        {          
             RuleFor(p => p.ProductName).NotEmpty().WithMessage("Product Name is required.");
        }

    }
}
