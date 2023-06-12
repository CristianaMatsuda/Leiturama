using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leiturama.Models;

public class Artigo
{
    public int Id {get; set;}

    public string Nome {get; set;}

    [Display(Name="Categoria")]
    public int CategoriaId {get; set;}
    [Display(Name="Gênero")]
    public int GeneroId {get; set;}

    [Display(Name="Preço")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Preco {get; set;}

    // Atributo de Relacionamento
    public virtual Categoria Categoria {get; set;}
}