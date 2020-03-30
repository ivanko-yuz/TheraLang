using Microsoft.Extensions.PlatformAbstractions;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TheraLang.IntegrationTests.DataBuilders
{
   public class UsersDetailsFormDataBuilder: FormDataBuilder
    {
        public UsersDetailsFormDataBuilder WithDefaultFirstName()
        {
            WithField(new StringContent("Andriana"), "FirstName");
            return this;
        }

        public UsersDetailsFormDataBuilder WithDefaultLastName()
        {
            WithField(new StringContent("Baran"), "LastName");
            return this;
        }

        public UsersDetailsFormDataBuilder WithDefaultPhoneNumber()
        {
            WithField(new StringContent("+380999999999"), "PhoneNumber");
            return this;
        }
    }
}
