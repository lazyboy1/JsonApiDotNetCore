using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Controllers.Annotations;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JsonApiDotNetCoreExampleTests.IntegrationTests.MultiTenancy
{
    [DisableRoutingConvention]
    [Route("{countryCode}/products")]
    public sealed class WebProductsController : JsonApiController<WebProduct>
    {
        public WebProductsController(IJsonApiOptions options, ILoggerFactory loggerFactory, IResourceService<WebProduct> resourceService)
            : base(options, loggerFactory, resourceService)
        {
        }
    }
}
