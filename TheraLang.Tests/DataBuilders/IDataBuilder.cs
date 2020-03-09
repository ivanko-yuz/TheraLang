namespace TheraLang.Tests.DataBuilders
{
    interface IDataBuilder<T>
    {
        T Build();
    }
}
