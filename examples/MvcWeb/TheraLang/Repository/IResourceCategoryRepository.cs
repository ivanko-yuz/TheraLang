namespace MvcWeb.UnitOfWork
{
    interface IResourceCategoryRepository
    {
        void ChangeType(int categoryId, string newType);
    }
}
