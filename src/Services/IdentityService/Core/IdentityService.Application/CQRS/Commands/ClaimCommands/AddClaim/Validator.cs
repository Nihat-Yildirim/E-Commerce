using FluentValidation;

namespace IdentityService.Application.CQRS.Commands.ClaimCommands.AddClaim
{
    public class Validator : AbstractValidator<AddClaimCommandRequest>
    {
        public Validator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(50);
        }
    }
}