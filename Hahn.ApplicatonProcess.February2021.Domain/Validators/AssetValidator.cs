using FluentValidation;
using Hahn.ApplicatonProcess.February2021.Domain.Models;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain.Validators
{
    public class AssetValidator : AbstractValidator<AssetViewModel>
    {
        public AssetValidator()
        {
            RuleFor(m => m.AssetName).NotEmpty();
            RuleFor(m => m.CountryOfDepartment).NotEmpty();
            RuleFor(m => m.EMailAdressOfDepartment).NotEmpty();
        }
    }
}
