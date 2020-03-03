using System;

namespace TheraLang.Tests
{
    public static class DefaultValues
    {
        public const int IntId = 1;
        public const string Name = "default name";
        
        public static readonly Guid Guid = new Guid("017a41aa-b005-4464-8cb6-1a6851b50c6f");
        public static readonly Uri Uri = new Uri("test/uri",UriKind.RelativeOrAbsolute);
    }
}