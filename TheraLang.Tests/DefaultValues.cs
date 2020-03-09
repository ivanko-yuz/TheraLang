using Common;
using System;
using TheraLang.BLL.DataTransferObjects.CommentDtos;

namespace TheraLang.Tests
{
    static class DefaultValues
    {
        public static readonly int ListSize = 10;
        public static readonly int FakeId = -10;
        public static readonly int ExistedId = 1;
        public static readonly PaginationParams PaginationParams = new PaginationParams() { PageNumber = 1, PageSize = 2 };
        public static readonly PaginationParams FakePaginationParams =
            new PaginationParams() { PageNumber = int.MaxValue, PageSize = int.MaxValue };
        public static readonly Guid UserGuid = new Guid("2960ECE9-49DA-431E-B5B2-9E9251260707");
        public static readonly Guid FakeGuid = new Guid("2960ECE9-49DA-431E-B5B2-9E9251261488");
    }
}
