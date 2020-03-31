using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using TheraLang.IntegrationTests.Infrastucture.TestDataSeeding;

namespace TheraLang.IntegrationTests.DataBuilders
{
    class UserJsonDataBuilder : JsonDataBuilder
    {
        public UserJsonDataBuilder WithDefaultRoleId()
        {
            WithField("new_role", DefaultValues.MemberRoleId.ToString());
            return this;
        }

        public UserJsonDataBuilder WithDefaultEmail()
        {
            WithField("email", "admin@utmm.com");
            return this;
        }

        public UserJsonDataBuilder WithDefaultPassword()
        {
            WithField("password", "password");
            return this;
        }
        public UserJsonDataBuilder WithDefaultConfirmPassword()
        {
            WithField("confirm_password", "password");
            return this;
        }

        public UserJsonDataBuilder WithDefailtFirstName()
        {
            WithField("FirstName", "Andriana");
            return this;
        }

        public UserJsonDataBuilder WithDefailtLastName()
        {
            WithField("LastName", "Baran");
            return this;
        }
        public UserJsonDataBuilder WithDefailtConfNum()
        {
            WithField("confirmation_number", "123456");
            return this;
        }

    }
}
