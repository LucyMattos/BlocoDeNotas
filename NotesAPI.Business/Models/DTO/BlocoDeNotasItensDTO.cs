using System.ComponentModel.DataAnnotations;

namespace NotesAPI.Business.Models.DTO
{
    public class BlocoDeNotasItensDTO
    {
        [Key]
        public int Id { get; set; }
        public int IdBlocoDeNotas { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(600)]
        public string? Descricao { get; set; }
    }
}
