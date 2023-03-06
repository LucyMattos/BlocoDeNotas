using NotesAPI.Data.Models.Entities;

namespace NotesAPI.Data.Interface
{
    public interface IBlocoDeNotasRepository : IRepository<BlocoDeNota>
    {
        Task<BlocoDeNota> GetAsync(int id);
    }
}
