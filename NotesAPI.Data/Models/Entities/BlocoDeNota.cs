﻿namespace NotesAPI.Data.Models.Entities
{
    public class BlocoDeNota : Base
    {
        public BlocoDeNota(string? titulo)
        {
            Titulo = titulo;
        }


        public string ? Titulo { get; set; } = null!;

        public virtual ICollection<BlocoDeNotasIten> BlocoDeNotasItens { get; } = new List<BlocoDeNotasIten>();

    }
}
