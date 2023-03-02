using NotesAPI.Business.models.Entities;
using System.ComponentModel.DataAnnotations;

namespace NotesAPI.Business.models.DTO
{
    public  class BlocoDeNotasDTO
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        public string? Titulo { get; set; }

        public IEnumerable<BlocoDeNotasItens>? Itens { get; set; }
    }
}
