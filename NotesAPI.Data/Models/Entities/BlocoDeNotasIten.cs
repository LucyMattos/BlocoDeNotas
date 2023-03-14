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

        private BlocoDeNotasIten()
        {

        }

        public int IdBlocoDeNotas { get; private set; }

        public string? Titulo { get; private set; } = null!;

        public string? Descricao { get; private set; }

        public virtual BlocoDeNota IdBlocoDeNotasNavigation { get; set; } = null!;
    }
}
