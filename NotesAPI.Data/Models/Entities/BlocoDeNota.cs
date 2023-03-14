namespace NotesAPI.Data.Models.Entities
{
    public class BlocoDeNota : Base
    {
        public BlocoDeNota(string? titulo)
        {
            Titulo = titulo;
        }

        private BlocoDeNota()
        {

        }

        public string ? Titulo { get; private set; } = null!;

        public virtual ICollection<BlocoDeNotasIten> BlocoDeNotasItens { get; } = new List<BlocoDeNotasIten>();

    }
}
