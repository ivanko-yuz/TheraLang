﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using TheraLang.IntegrationTests.Infrastucture.TestAuthentication;

public class TestAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
{
    private readonly IList<Claim> _claims;

    public TestAuthHandler(IOptionsMonitor<AuthenticationSchemeOptions> options,
        ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, TestClaimsProvider claimsProvider)
        : base(options, logger, encoder, clock)
    {
        _claims = claimsProvider.Claims;
    }

    protected override Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        var identity = new ClaimsIdentity(_claims, "Test");
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, "Test");
        AuthenticateResult result;

        //Do not authorize users without any claims
        if (_claims.Any())
        {
            result = AuthenticateResult.Success(ticket);
        }
        else
        {
            result = AuthenticateResult.NoResult();
        }

        return Task.FromResult(result);
    }
}