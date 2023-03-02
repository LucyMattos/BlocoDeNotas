using NotesAPI.Business.Models.Entities;

namespace NotesAPI.Data.Interface
{
    public interface IBlocoDeNotasRepository : IRepository<BlocoDeNotas>
    {
        Task<BlocoDeNotas> GetAsync(int id);
    }
}
