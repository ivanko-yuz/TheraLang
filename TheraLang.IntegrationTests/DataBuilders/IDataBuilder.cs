namespace TheraLang.IntegrationTests.DataBuilders
{
    public interface IDataBuilder<T>
    {
        T Build();
    }
}
