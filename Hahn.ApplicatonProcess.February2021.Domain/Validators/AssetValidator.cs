using FluentValidation;
using Hahn.ApplicatonProcess.February2021.Domain.Models;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain.Validators
{
    public class AssetValidator : AbstractValidator<AssetViewModel>
    {
        public AssetValidator(IStringLocalizer stringLocalizer)
        {

            RuleFor(m => m.AssetName).NotEmpty().WithMessage(stringLocalizer["asset.assetname.empty"]);
            RuleFor(m => m.CountryOfDepartment).NotEmpty().WithMessage(stringLocalizer["asset.countryofdepartment.empty"]);
            RuleFor(m => m.EMailAdressOfDepartment).NotEmpty().WithMessage(stringLocalizer["asset.emailadressofdepartment.empty"]);
        }
    }
}
