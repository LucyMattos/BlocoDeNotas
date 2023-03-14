using NotesAPI.Business.Models.DTO;

namespace NotesAPI.Business.Models.ViewModel
{
    public class BlocoDeNotasVM
    {
        public string? Titulo { get; set; }

        public IEnumerable<BlocoDeNotasItensDTO>? Itens { get; set; }
    }
}
