using System;
using System.ComponentModel.DataAnnotations;

namespace Imobiliaria.Models;

public class Cliente
{
    public int Id {get; set;}
    public string? Nome {get; set;}
    [DataType(DataType.Date)]
    public DateTime DataNascimento {get; set;}
    public string? Endereco {get; set;}
    public decimal Renda {get; set;}
}