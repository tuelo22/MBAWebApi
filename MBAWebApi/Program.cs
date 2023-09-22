using HealthChecks.UI.Client;
using MBAWebApi.HealthCheck;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Health Check
builder.Services
    .AddHealthChecks()

    .AddSqlServer(
        connectionString: builder.Configuration.GetConnectionString("banco") ?? string.Empty,
        healthQuery: "SELECT 1",
        name: "Database",
        failureStatus: Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy
    )
    .AddUrlGroup(new Uri("https://httpbin.org/status/200"), "Api Terceiro não autenticada")
    .AddCheck<HealthCheckRandom>(name: "API RANDOM"); ;

builder.Services
    .AddHealthChecksUI(s =>
    {
        s.AddHealthCheckEndpoint("MBA WEBAPI", "https://localhost:44373/healthz");
    }).AddInMemoryStorage();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseRouting()
    .UseEndpoints(config =>
    {
        config.MapHealthChecks("/healthz", new HealthCheckOptions
        {
            Predicate = _ => true,
            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
        });

        config.MapHealthChecksUI();
    });

app.Run();


