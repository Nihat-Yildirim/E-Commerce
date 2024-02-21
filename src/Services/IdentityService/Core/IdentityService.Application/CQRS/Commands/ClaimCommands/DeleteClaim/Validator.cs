using FluentValidation;

namespace IdentityService.Application.CQRS.Commands.ClaimCommands.DeleteClaim
{
    public class Validator : AbstractValidator<DeleteClaimCommandRequest>
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