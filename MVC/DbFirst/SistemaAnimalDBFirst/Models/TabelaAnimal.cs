using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SistemaAnimalDBFirst.Models;

[Table("TabelaAnimal")]
public partial class TabelaAnimal
{
    [Key]
    public int Id { get; set; }

    [StringLength(120)]
    public string Nome { get; set; } = null!;

    [StringLength(120)]
    public string Som { get; set; } = null!;

    [Column("TipoALimentacao")]
    [StringLength(30)]
    public string TipoAlimentacao { get; set; } = null!;

    [StringLength(30)]
    public string Animal { get; set; } = null!;
}
