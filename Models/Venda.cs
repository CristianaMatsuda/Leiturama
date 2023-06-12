using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leiturama.Models;

public class Venda
{
    public int Id {get; set;}

    public int ArtigoId {get; set;}
    public int Quantidade {get; set;}
    public string DtVenda {get; set;}
}