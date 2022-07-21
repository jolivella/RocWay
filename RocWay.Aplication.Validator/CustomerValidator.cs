using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using RocWay.Application.DTO;

namespace RocWay.Application.Validator
{
    public class CustomerValidator: AbstractValidator<CustomerDto>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CompanyName).NotEmpty()
                .WithMessage("Debe proporcionar el Nombre del Negocio");
            RuleFor(C => C.CompanyName).Must(IsRegiteredName).WithMessage("Nombre de Aplicacion ya se encuentra registrado");
        }

        private bool IsRegiteredName(string companyName)
        {
            return true;
        }
    }
}
 