using Common;
using System;

namespace TheraLang.Tests.DataBuilders
{
    public static class DefaultValues
    {
        public static Guid UserGuid = new Guid("2960ECE9-49DA-431E-B5B2-9E9251260707");
        public static PaginationParams PaginationParams = new PaginationParams() {PageNumber = 2, PageSize = 2};
    }
}