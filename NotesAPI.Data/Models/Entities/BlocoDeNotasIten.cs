namespace NotesAPI.Data.Models.Entities
{
    public class BlocoDeNotasIten : Base
    {
        public BlocoDeNotasIten(int idBlocoDeNotas, string? titulo, string? descricao)
        {
            IdBlocoDeNotas = idBlocoDeNotas;
            Titulo = titulo;
            Descricao = descricao;
        }

        public int IdBlocoDeNotas { get; set; }

        public string? Titulo { get; set; } = null!;

        public string? Descricao { get; set; }

        public virtual BlocoDeNota IdBlocoDeNotasNavigation { get; set; } = null!;
    }
}
