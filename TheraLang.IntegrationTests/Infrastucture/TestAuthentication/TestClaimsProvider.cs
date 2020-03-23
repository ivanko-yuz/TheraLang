using System.Collections.Generic;
using System.Security.Claims;
using TheraLang.IntegrationTests.Infrastucture.TestDataSeeding;

namespace TheraLang.IntegrationTests.Infrastucture.TestAuthentication
{
    public class TestClaimsProvider
    {
        public IList<Claim> Claims { get; }

        public TestClaimsProvider(IList<Claim> claims)
        {
            Claims = claims;
        }

        public TestClaimsProvider()
        {
            Claims = new List<Claim>();
        }

        public static TestClaimsProvider WithAdminClaims()
        {
            var provider = new TestClaimsProvider();

            provider.Claims.Add(new Claim("Id", DefaultValues.AdminId.ToString()));
            provider.Claims.Add(new Claim(ClaimTypes.Email, "admin@utmm.com"));
            provider.Claims.Add(new Claim(ClaimTypes.Role, "Admin"));

            return provider;
        }

        public static TestClaimsProvider WithMemberClaims()
        {
            var provider = new TestClaimsProvider();

            provider.Claims.Add(new Claim("Id", DefaultValues.MemberId.ToString()));
            provider.Claims.Add(new Claim(ClaimTypes.Email, "member@utmm.com"));
            provider.Claims.Add(new Claim(ClaimTypes.Role, "Member"));

            return provider;
        }
    }
}
