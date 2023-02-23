﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Soube.Infrastructure.ADO.Data;

public partial class Endereco
{
    [Key]
    public int Id { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string CEP { get; set; }

    [Required]
    [StringLength(80)]
    [Unicode(false)]
    public string Nome { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Pais { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string UF { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Cidade { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string Bairro { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Numero { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Complemento { get; set; }

    public bool? ZonaUrbana { get; set; }

    [InverseProperty("Endereco")]
    public virtual ICollection<Pessoa> Pessoa { get; } = new List<Pessoa>();
}