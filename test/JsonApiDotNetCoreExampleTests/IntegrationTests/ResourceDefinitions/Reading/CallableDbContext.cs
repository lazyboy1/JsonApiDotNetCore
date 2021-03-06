using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace JsonApiDotNetCoreExampleTests.IntegrationTests.ResourceDefinitions.Reading
{
    [UsedImplicitly(ImplicitUseTargetFlags.Members)]
    public sealed class CallableDbContext : DbContext
    {
        public DbSet<CallableResource> CallableResources { get; set; }

        public CallableDbContext(DbContextOptions<CallableDbContext> options)
            : base(options)
        {
        }
    }
}
