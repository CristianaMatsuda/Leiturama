using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leiturama.Models;

public class Venda
{
    public int Id {get; set;}

    public string ArtigoId {get; set;}
    public int Quantidade {get; set;}
    [DataType(DataType.Date)]
    public DateTime DtVenda {get; set;}

    // Atributo de Relacionamento
    // public virtual Categoria Categoria {get; set;}
}