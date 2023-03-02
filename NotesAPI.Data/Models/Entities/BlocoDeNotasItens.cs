namespace NotesAPI.Data.Models.Entities
{
    public class BlocoDeNotasItens : Base
    {
        public BlocoDeNotasItens(int idBlocoDeNotas, string? titulo, string? descricao)
        {
            IdBlocoDeNotas = idBlocoDeNotas;
            Titulo = titulo;
            Descricao = descricao;
        }

        public int IdBlocoDeNotas { get; private set; }
        public string? Titulo { get; private set; }
        public string? Descricao { get; private set; }
    }
}
