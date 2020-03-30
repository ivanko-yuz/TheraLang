using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using TheraLang.IntegrationTests.Infrastucture.TestDataSeeding;

namespace TheraLang.IntegrationTests.DataBuilders
{
    class UserFormDataBuilder : FormDataBuilder
    {
        public UserFormDataBuilder WithDefaultRoleId()
        {
            WithField(new StringContent(DefaultValues.MemberRoleId.ToString()), "new_role");
            return this;
        }

    }
}
