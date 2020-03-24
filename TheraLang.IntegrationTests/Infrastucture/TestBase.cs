using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using TheraLang.IntegrationTests.Infrastucture.TestAuthentication;
using Xunit;

namespace TheraLang.IntegrationTests.Infrastucture
{
    public class TestBase : IClassFixture<TestFixture>
    {
        public HttpClient UnauthorizedClient;
        public HttpClient AdminClient;
        public HttpClient MemberClient;

        public TestBase(TestFixture testFixture)
        {
            UnauthorizedClient = testFixture.CreateClient(TestClaimsProvider.Unauthorized());
            AdminClient = testFixture.CreateClient(TestClaimsProvider.WithAdminClaims());
            MemberClient = testFixture.CreateClient(TestClaimsProvider.WithMemberClaims());
        }
    }
}
