using System;
using System.Linq;
using System.Text.RegularExpressions;
using FluentValidation;

namespace AvanadeLogin.Core.Models
{
    public class UserAccountModelValidator : AbstractValidator<UserAccountModel>
    {
        public const string SpecialCharacters = "!@#$%^&";

        public UserAccountModelValidator()
        {
            RuleFor(x => x.FirstName)
                .Must(NotContainsSpecialCharacters).WithMessage($"Must not contain {SpecialCharacters}.");

            RuleFor(x => x.LastName)
                .Must(NotContainsSpecialCharacters).WithMessage($"Must not contain {SpecialCharacters}.");

            RuleFor(x => x.Password)
                .Length(8, 15).WithMessage("Must be between 8-15 chars.");

            RuleFor(x => x.Password)
                .Must(OneUpperCase).WithMessage("At least one letter must be uppercase.");

            RuleFor(x => x.Password)
                .Must(OneLowerCase).WithMessage("At least one letter must be lowercase.");


            //RuleFor(x => x.Forename).NotEmpty().WithMessage("Please specify a first name");
            //RuleFor(x => x.Discount).NotEqual(0).When(x => x.HasDiscount);
            //RuleFor(x => x.Address).Length(20, 250);
            //RuleFor(x => x.Postcode).Must(BeAValidPostcode).WithMessage("Please specify a valid postcode");
        }

        private bool NotContainsSpecialCharacters(string arg)
        {
            var reg = new Regex($"^[^{SpecialCharacters}]*$");
            return reg.IsMatch(arg);
        }

        private bool OneLowerCase(string arg)
        {
            return arg.Any(char.IsLower);
        }

        private bool OneUpperCase(string arg)
        {
            return arg.Any(char.IsUpper);
        }
    }
}
