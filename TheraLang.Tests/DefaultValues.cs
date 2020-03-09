using Common;
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
        public static readonly CommentRequestDto CommentRequest = new CommentRequestDto() { Text = "Text" };
    }
}
