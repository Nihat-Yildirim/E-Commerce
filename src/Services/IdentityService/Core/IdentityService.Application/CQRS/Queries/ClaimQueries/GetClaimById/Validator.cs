using FluentValidation;

namespace IdentityService.Application.CQRS.Queries.ClaimQueries.GetClaimById
{
    public class Validator : AbstractValidator<GetClaimByIdQueryRequest>
    {
        public Validator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .Must(x => x.ToString().Length == 36);
        }
    }
}