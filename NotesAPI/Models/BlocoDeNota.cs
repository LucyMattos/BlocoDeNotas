using System;
using System.Collections.Generic;

namespace NotesAPI.Models;

public partial class BlocoDeNota
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public virtual ICollection<BlocoDeNotasIten> BlocoDeNotasItens { get; } = new List<BlocoDeNotasIten>();
}
