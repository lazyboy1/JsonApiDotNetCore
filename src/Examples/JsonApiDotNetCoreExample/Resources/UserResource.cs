using System.Collections.Generic;
using System.Linq;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCoreExample.Models;

namespace JsonApiDotNetCoreExample.Resources
{
    public class UserResource : ResourceDefinition<User>
    {
        protected override List<AttrAttribute> OutputAttrs()
            => Remove(user => user.Password);

        public override IQueryable<User> OnList(IQueryable<User> entities) => entities;
    }
}
