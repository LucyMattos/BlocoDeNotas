namespace NotesAPI.Business.Models.Entities
{
    public class BlocoDeNotasItens
    {
        public BlocoDeNotasItens(int id, int idBlocoDeNotas, string? titulo, string? descricao)
        {
            Id = id;
            IdBlocoDeNotas = idBlocoDeNotas;
            Titulo = titulo;
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public int IdBlocoDeNotas { get; private set; }
        public string? Titulo { get; private set; }
        public string? Descricao { get; private set; }
    }
}
