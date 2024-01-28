using FastEndpoints;
using FluentValidation;

namespace WebAPI.Endpoints.Actor.Get;

public class GetActorValidator : Validator<GetActorRequest>
{
    public GetActorValidator()
    {
        RuleFor(x => x.Id)
            .NotEqual(Guid.Empty)
            .WithMessage($"Id must not equal {Guid.Empty}");
    }
}