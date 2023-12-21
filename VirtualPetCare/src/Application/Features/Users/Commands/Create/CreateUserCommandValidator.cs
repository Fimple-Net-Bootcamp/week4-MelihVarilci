using Application.Features.Users.Constants;
using FluentValidation;

namespace Application.Features.Users.Commands.Create;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(c => c.FirstName).NotEmpty().MinimumLength(2);
        RuleFor(c => c.LastName).NotEmpty().MinimumLength(2);
        RuleFor(c => c.Email).NotEmpty().EmailAddress();
        RuleFor(c => c.Phone).Must(PhoneNumberIsValid);
    }

    private static bool PhoneNumberIsValid(string phoneNumber)
    {
        return RegexConstants.PhoneNumberRegex().IsMatch(phoneNumber);
    }
}