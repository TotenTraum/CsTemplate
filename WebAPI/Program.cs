using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddFastEndpoints()
    .AddSwaggerGen().SwaggerDocument(o =>
    {
        o.DocumentSettings = s =>
        {
            s.Title = "Template API";
            s.Version = "v1";
        };
        o.TagDescriptions = t =>
        {
            t["tag"] = "Description";
        };
    });

var app = builder.Build();

app.UseFastEndpoints(c =>
{
    c.Endpoints.Configurator = endpoints => endpoints.AllowAnonymous();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerGen();
}

app.UseHttpsRedirection();

app.Run();