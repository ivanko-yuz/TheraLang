using Common;
using System;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.DataTransferObjects.CommentDtos;

namespace TheraLang.Tests
{
    public static class DefaultValues
    {
        public const int IntId = 1;
        public const string Name = "default name";
        
        public static readonly Guid Guid = new Guid("017a41aa-b005-4464-8cb6-1a6851b50c6f");
        public static readonly Uri Uri = new Uri("test/uri",UriKind.RelativeOrAbsolute);
        public static readonly int ListSize = 10;
        public static readonly int FakeId = -10;
        public static readonly int ExistedId = 1;
        public static readonly PaginationParams PaginationParams = new PaginationParams() { PageNumber = 1, PageSize = 2 };
        public static readonly PaginationParams FakePaginationParams =
            new PaginationParams() { PageNumber = int.MaxValue, PageSize = int.MaxValue };
        public static readonly UserAllDto userAll = new UserAllDto()
        {
            FirstName = "Andriana",
            LastName = "Baran",
            Email = "andriana@gmail.com",
            Password = "password",
        };
        public static readonly Guid UserGuid = new Guid("2960ECE9-49DA-431E-B5B2-9E9251260707");
        public static readonly Guid FakeGuid = new Guid("2960ECE9-49DA-431E-B5B2-9E9251261488");
    }
}