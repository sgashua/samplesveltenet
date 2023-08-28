using Carter;
using Microsoft.AspNetCore.Http.Json;
using SampleSvelteNET.Application.Modules;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(BaseModule).Assembly);
});
builder.Services.AddCarter();
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.PropertyNamingPolicy = null;
});

var app = builder.Build();
app.UseCors(options =>
{
    options.WithOrigins("http://localhost:5173").AllowAnyMethod().AllowAnyHeader();
});
app.MapCarter();
app.Run();