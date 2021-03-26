using FluentValidation;
using Hahn.ApplicatonProcess.February2021.Domain.Helpers;
using Hahn.ApplicatonProcess.February2021.Domain.Interfaces;
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
        public AssetValidator(IStringLocalizer stringLocalizer, ICountryService countryService, IObjectHelper objectHelper)
        {

            RuleFor(m => m.AssetName).NotEmpty().WithMessage(stringLocalizer["asset.assetname.empty"])
                .MinimumLength(10).WithMessage(stringLocalizer["asset.assetname.minlength"]);

            RuleFor(m => m.CountryOfDepartment).NotEmpty().WithMessage(stringLocalizer["asset.countryofdepartment.empty"]);

            RuleFor(m => m.CountryOfDepartment).Must(country => countryService.ExistsCountry(country))
                .WithMessage(stringLocalizer["asset.countryofdepartment.valid"]);

            RuleFor(m => m.PurchaseDate).Must(purchaseDate => objectHelper.IsNotOlderThanOneYear(purchaseDate))
                .WithMessage(stringLocalizer["asset.purchasedate.olderthanayear"]);

            RuleFor(m => m.EMailAdressOfDepartment)
                .EmailAddress().WithMessage(stringLocalizer["asset.emailadressofdepartment.valid"])
                .NotEmpty().WithMessage(stringLocalizer["asset.emailadressofdepartment.empty"]);
        }
    }
}
