using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Soube.Infrastructure.ADO.Data;

public partial class WeatherForecast
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "date")]
    public DateTime Date { get; set; }

    public int Temperature { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Summary { get; set; }
}