using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TheraLang.Web.Extensions
{
    public static class AuthExtension
    {

        public static Guid? GetUserId(this IEnumerable<Claim> claims)
        {
            var userId = claims.FirstOrDefault(x => x.Type == "Id")?.Value;
            if (userId == null)
            {
                return null;
            }

            return new Guid(userId);
        }
    }
}
