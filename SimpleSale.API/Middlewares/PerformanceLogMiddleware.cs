using System.Diagnostics;

namespace SimpleSale.API.Middlewares
{
    public class PerformanceLogMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerFactory _loggerFactory;

        public PerformanceLogMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _loggerFactory = loggerFactory;
        }

        public async Task Invoke(HttpContext context)
        {
            var timer = Stopwatch.StartNew();

            await _next(context);

            timer.Stop();

            var duration = timer.ElapsedMilliseconds;
            var logger = _loggerFactory.CreateLogger("Performance");

            if (duration > 10000)
            {
                logger.LogWarning("Long running request: {Method} - {Path} ({duration} milliseconds)", context.Request.Method, context.Request.Path, duration);
            }
        }
    }
}
