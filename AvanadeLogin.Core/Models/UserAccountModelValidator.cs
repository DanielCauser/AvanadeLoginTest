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

            RuleFor(x => x.Password)
                .Must(NotBeRepetitive).WithMessage("Must not have repetitive sequence of characters.");

            RuleFor(x => x.ServiceStartDate)
                .GreaterThanOrEqualTo(DateTime.Now.Date).WithMessage("A past date is not allowed.");

            RuleFor(x => x.ServiceStartDate)
                .LessThanOrEqualTo(DateTime.Now.Date.AddDays(30)).WithMessage("A date more than 30 days into the future is not allowed.");
        }

        private bool NotBeRepetitive(string arg)
        {
            var reg = new Regex("(?!\\s)[^%\n]*$");
            return reg.IsMatch(arg);
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
