using NotesAPI.Business.Models.DTO;
using NotesAPI.Business.Models.ViewModel;

namespace NotesAPI.Business.Interface
{
    public interface IBlocoDeNotasBusiness
    {
        Task<BlocoDeNotasDTO> GetAsync (int id);
        Task<List<BlocoDeNotasDTO>> GetAllAsync();
        Task<BlocoDeNotasDTO> AddAsync(AddBlocoDeNotas notas);
        Task<BlocoDeNotasDTO> UpdateAsync (UpdateBlocoDeNotas notas);
        Task DeleteAsync(int id);
    }
}
