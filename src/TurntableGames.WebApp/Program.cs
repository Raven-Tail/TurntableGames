using Core.Common.Behaviors;
using Mediator;
using Scalar.AspNetCore;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

// Common
services.AddSerilog();
services.AddOpenApi();

// Mediator
services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LogRequestBehavior<,>));
services.AddScoped(typeof(IPipelineBehavior<,>), typeof(RunnerBehavior<,>));
services.AddBlackwing();
services.AddBlackwingHandlers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference("/docs");
}

app.UseHttpsRedirection();

// Cringy Game
var grp = app.MapGroup("/api/cringy-game");

//grp.MapPost("", (CreateGame request, ISender sender) => sender.Send(request).ToOk());

// todo: add other methods related to the requests and implement their command handlers with a throw new not implemented exception.
// we just need to make sure all commands are executed to the handlers

await app.RunAsync();
