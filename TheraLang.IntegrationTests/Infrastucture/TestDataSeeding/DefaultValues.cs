using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.IntegrationTests.Infrastucture.TestDataSeeding
{
    public static class DefaultValues
    {
        //Users ids
        public static readonly Guid AdminId = new Guid("f5aa0c0e-b669-466c-825a-2c52c58a019b");
        public static readonly Guid MemberId = new Guid("3bcec608-e6a4-45e5-b3b2-cdf252a639de");

        //Roles ids
        public static readonly Guid AdminRoleId = new Guid("f4cbff0f-4bc0-42a4-9738-8d9f9bb734ba");
        public static readonly Guid MemberRoleId = new Guid("50245ab3-6770-4269-ac26-30a942116a70");
        public static readonly Guid GuestRoleId = new Guid("7e9b3674-e720-4d50-939b-93ce8e8b1c44");
        public static readonly Guid UnconfirmedRoleId = new Guid("5ea1ce2d-1bf0-4d39-a01b-a5d90962bdb1");
        public static readonly Guid BlockedRoleId = new Guid("7a0f5ea1-f192-4188-bc98-b59d95f6e109");
    }
}
