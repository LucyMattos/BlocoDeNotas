using NotesAPI.Data.Models.Entities;
namespace NotesAPI.Data.Interface
{
    public interface IBlocoDeNotasItensRepository : IRepository<BlocoDeNotasIten>
    {
        Task<BlocoDeNotasIten> GetAsync(int id);
    }
}
