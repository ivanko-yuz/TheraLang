namespace TheraLang.Tests.DataBuilders
{
    public interface IDataBuilder<T>
    {
        T Build();
    }
}