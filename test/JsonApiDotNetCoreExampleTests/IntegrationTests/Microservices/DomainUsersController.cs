using System;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;

namespace JsonApiDotNetCoreExampleTests.IntegrationTests.Microservices
{
    public sealed class DomainUsersController : JsonApiController<DomainUser, Guid>
    {
        public DomainUsersController(IJsonApiOptions options, ILoggerFactory loggerFactory, IResourceService<DomainUser, Guid> resourceService)
            : base(options, loggerFactory, resourceService)
        {
        }
    }
}
