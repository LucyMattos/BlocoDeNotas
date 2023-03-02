using NotesAPI.Business.Models.DTO;

namespace NotesAPI.Business.Interface
{
    public interface IBlocoDeNotasBusiness
    {
        Task<BlocoDeNotasDTO> GetAsync (int id);
        Task<List<BlocoDeNotasDTO>> GetAllAsync();
    }
}
