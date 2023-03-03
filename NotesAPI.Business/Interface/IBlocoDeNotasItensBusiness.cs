
using NotesAPI.Business.Models.DTO;

namespace NotesAPI.Business.Interface
{
    public interface IBlocoDeNotasItensBusiness
    {
        Task<BlocoDeNotasItensDTO> GetAsync(int id);
        Task<List<BlocoDeNotasItensDTO>> GetAllAsync();
        Task<BlocoDeNotasItensDTO> AddAsync(BlocoDeNotasItensDTO notas);
        Task UpdateAsync(BlocoDeNotasItensDTO notas);
        Task DeleteAsync(int id);
    }
}
