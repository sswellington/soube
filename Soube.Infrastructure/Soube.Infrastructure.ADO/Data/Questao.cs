﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Soube.Infrastructure.ADO.Data;

public partial class Questao
{
    [Key]
    public int Id { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string Enunciado { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Alternativa { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string Gabarito { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Comentario { get; set; }

    [Column(TypeName = "date")]
    public DateTime Ano { get; set; }

    public int? SimuladoId { get; set; }

    public int? MateriaId { get; set; }

    public int BancaId { get; set; }

    public int SituacaoId { get; set; }

    [ForeignKey("BancaId")]
    [InverseProperty("Questao")]
    public virtual PessoaJuridica Banca { get; set; }

    [ForeignKey("MateriaId")]
    [InverseProperty("Questao")]
    public virtual Materia Materia { get; set; }

    [ForeignKey("SimuladoId")]
    [InverseProperty("Questao")]
    public virtual Simulado Simulado { get; set; }

    [InverseProperty("Questao")]
    public virtual ICollection<SimuladoQuestao> SimuladoQuestao { get; } = new List<SimuladoQuestao>();

    [ForeignKey("SituacaoId")]
    [InverseProperty("Questao")]
    public virtual Situacao Situacao { get; set; }
}