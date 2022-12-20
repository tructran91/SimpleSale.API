using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SimpleSale.API;
using SimpleSale.API.Extensions;
using SimpleSale.API.Filters;
using SimpleSale.Application.Interfaces;
using SimpleSale.Application.Services;
using SimpleSale.Core.Interfaces;
using SimpleSale.Core.Repositories;
using SimpleSale.Infrastructure.Data;
using SimpleSale.Infrastructure.Logging;
using SimpleSale.Infrastructure.Repository;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.AddLayerForApp();
builder.Services.ConfigureSwagger();
builder.Services.ConfigureCorsAllowAny();
builder.Services.AddScoped<ModelValidationAttribute>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
    app.UseDeveloperExceptionPage();
}
app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.UseExceptionHandler(config =>
{
    config.Run(async context =>
    {
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.Response.ContentType = "application/json";

        var ex = context.Features.Get<IExceptionHandlerFeature>();
        if (ex != null)
        {
            var err = $"<h1>Error: {ex.Error.Message}</h1>{ex.Error.StackTrace}";
            await context.Response.WriteAsync(err).ConfigureAwait(false);
        }
    });
});

//using (var scope = app.Services.CreateScope())
//{
//    var aspnetRunContext = scope.ServiceProvider.GetRequiredService<SimpleSaleDbContext>();
//    SimpleSaleSeed.SeedAsync(aspnetRunContext).Wait();
//}

app.Run();
