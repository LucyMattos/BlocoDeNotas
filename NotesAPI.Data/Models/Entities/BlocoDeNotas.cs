namespace NotesAPI.Data.Models.Entities
{
    public class BlocoDeNotas : Base
    {
        public BlocoDeNotas(string? titulo)
        {
            Titulo = titulo;
        }

        public string? Titulo { get; private set; }

        public IEnumerable<BlocoDeNotasItens>? Itens { get; private set; }

    }
}
