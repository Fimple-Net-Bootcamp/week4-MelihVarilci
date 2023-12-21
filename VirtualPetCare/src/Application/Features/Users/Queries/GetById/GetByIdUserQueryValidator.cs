using FluentValidation;

namespace Application.Features.Users.Queries.GetById;

public class GetByIdUserQueryValidator : AbstractValidator<GetByIdUserQuery>
{
    public GetByIdUserQueryValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}