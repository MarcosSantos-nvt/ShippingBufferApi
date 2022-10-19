using CrossCutting.Ioc;
using Havan.AspNetCore.Swashbuckle;
using Havan.Logistica.Core.Extensions;

var builder = WebApplication.CreateBuilder(args);

NativeInjectorBootstrapper.RegisterServices(builder.Services);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHealthChecks();
builder.Services.AddAuthorization();
builder.Services.AddHavanServices();
builder.Services.AddMixedAuthentication();
builder.Services.AddLogisticaCore();
builder.Services.AddSwaggerDefaultConfiguration(new SwaggerInfo()
{
    Version = "v1",
    Title = "API Shipping Buffer",
    Description = "API de automação Shipping Buffer",
    RoutePrefix = "Swagger"
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.UseHealthChecks("/health");

app.MapControllers();

app.Run();
