using NotesAPI.Business.Models.DTO;

namespace NotesAPI.Business.Interface
{
    public interface IBlocoDeNotasBusiness
    {
        Task<BlocoDeNotasDTO> GetAsync (int id);
        Task<List<BlocoDeNotasDTO>> GetAllAsync();
        Task<BlocoDeNotasDTO> AddAsync(BlocoDeNotasDTO notas);
        Task UpdateAsync (BlocoDeNotasDTO notas);
        Task DeleteAsync(int id);
    }
}
