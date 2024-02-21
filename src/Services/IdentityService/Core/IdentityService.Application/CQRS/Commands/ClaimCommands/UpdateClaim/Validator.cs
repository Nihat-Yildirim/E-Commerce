using FluentValidation;

namespace IdentityService.Application.CQRS.Commands.ClaimCommands.UpdateClaim
{
    public class Validator : AbstractValidator<UpdateClaimCommandRequest>
    {
        public Validator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .Must(x => x.ToString().Length == 36);

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(50);
        }
    }
}