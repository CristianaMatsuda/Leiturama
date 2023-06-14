using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Leiturama.Models;

public class Genero
{
    public int Id {get; set;}
    [Display(Name="Gênero")]
    public string Nome {get; set;}

    // Atributo de Relacionamento
    public virtual List<Artigo>? Artigos {get; set;}
}