using NotesAPI.Data.Models.Entities;

namespace NotesAPI.Data.Interface
{
    public interface IBlocoDeNotasRepository : IRepository<BlocoDeNotas>
    {
        Task<BlocoDeNotas> GetAsync(int id);
    }
}
