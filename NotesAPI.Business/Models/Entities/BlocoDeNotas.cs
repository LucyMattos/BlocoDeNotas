namespace NotesAPI.Business.Models.Entities
{
    public class BlocoDeNotas
    {
        public BlocoDeNotas(int id, string? titulo)
        {
            Id = id;
            Titulo = titulo;
        }

        public int Id { get; private set; }
        public string? Titulo { get; private set; }

        public IEnumerable<BlocoDeNotasItens>? Itens { get; private set; }

    }
}
