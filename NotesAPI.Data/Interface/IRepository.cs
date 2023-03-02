namespace NotesAPI.Data.Interface
{
    public interface IRepository<T>
    {
        Task<T> AddAsync(T entity, bool saveChanges = true);
        Task UpdateAsync(T entity, bool saveChanges = true);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
