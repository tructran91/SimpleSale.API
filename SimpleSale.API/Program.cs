using Microsoft.AspNetCore.Diagnostics;
using SimpleSale.API.Extensions;
using SimpleSale.API.Middlewares;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.AddLayerForApp();
builder.Services.ConfigureSwagger();
builder.Services.ConfigureCorsAllowAny();

var app = builder.Build();

var loggerFactory = app.Services.GetService<ILoggerFactory>();
loggerFactory.AddFile(builder.Configuration["Logging:LogFilePath"].ToString());

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

app.UseMiddleware<PerformanceLogMiddleware>();

app.Run();
