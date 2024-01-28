using FastEndpoints;

namespace WebAPI.Endpoints.Actor.Get;

public class GetActor: Endpoint<GetActorRequest, GetActorResponse>
{
    public override void Configure()
    {
        Get("api/actor/");
    }

    public override async Task HandleAsync(GetActorRequest req, CancellationToken ct)
    {
        await SendOkAsync(new GetActorResponse{Name = "John"}, ct);
    }
}