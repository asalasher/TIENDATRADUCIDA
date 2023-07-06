namespace TIENDA2.domain.Contracts
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>?> GetAll();
        Task<T?> GetByID(int id);
        Task<T?> Add(T entity);
        Task<T?> Delete(int id);
        Task<T?> Update(T entity);
        Task<IEnumerable<T>?> AddBulk(IEnumerable<T> entities);
        Task<IEnumerable<T>?> DeleteBulk(IEnumerable<int> entities);
    }
}
