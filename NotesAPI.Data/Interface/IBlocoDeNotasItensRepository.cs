using NotesAPI.Data.Models.Entities;
namespace NotesAPI.Data.Interface
{
    public interface IBlocoDeNotasItensRepository : IRepository<BlocoDeNotasItens>
    {
        Task<BlocoDeNotasItens> GetAsync(int id);
    }
}
