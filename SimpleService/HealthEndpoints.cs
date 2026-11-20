namespace SimpleService;

internal static class HealthEndpoints
{
    internal static void MapHealth(this WebApplication app)
    {
        app.MapGet("/health", (CancellationToken _) => TypedResults.Ok(new HealthResponse("ok")))
            .WithName("GetHealth")
            .WithSummary("Check that the API is running")
            .WithDescription("Returns a liveness response without checking external dependencies.");
    }
}

/// <summary>Reports that the API is responding to requests.</summary>
public sealed record HealthResponse(string Status);
