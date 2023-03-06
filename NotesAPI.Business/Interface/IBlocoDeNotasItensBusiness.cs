
using NotesAPI.Business.Models.DTO;
using NotesAPI.Business.Models.ViewModel;

namespace NotesAPI.Business.Interface
{
    public interface IBlocoDeNotasItensBusiness
    {
        Task<BlocoDeNotasItensDTO> GetAsync(int id);
        Task<List<BlocoDeNotasItensDTO>> GetAllAsync();
        Task<BlocoDeNotasItensDTO> AddAsync(AddBlocoDeNotasItens notas);
        Task UpdateAsync(UpdateBlocoDeNotasItens notas);
        Task DeleteAsync(int id);
    }
}
