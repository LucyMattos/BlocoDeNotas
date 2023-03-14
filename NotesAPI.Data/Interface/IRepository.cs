namespace NotesAPI.Data.Interface
{
    public interface IRepository<T>
    {
        Task<T> AddAsync(T entity, bool saveChanges = true);
        Task<T> UpdateAsync(T entity, bool saveChanges = true);
        Task DeleteAsync(T entity, bool saveChanges = true);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
