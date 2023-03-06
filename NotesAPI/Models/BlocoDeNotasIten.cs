using System;
using System.Collections.Generic;

namespace NotesAPI.Models;

public partial class BlocoDeNotasIten
{
    public int Id { get; set; }

    public int IdBlocoDeNotas { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Descricao { get; set; }

    public virtual BlocoDeNota IdBlocoDeNotasNavigation { get; set; } = null!;
}
