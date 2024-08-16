using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Ordering.API
{
    internal class HealthcCheckOptions : HealthCheckOptions
    {
        public Func<HttpContext, HealthReport, Task> RessponseWriter { get; set; }
    }
}