using System.ComponentModel.DataAnnotations;

namespace MVC2.Models;

public class Movie
{
    public int Id {get; set;}
    public string? Title {get; set;}
    [DataType(DataType.Date)]
    public DateTime Releasedate {get; set;}
    public string? Genre {get; set;}
    public decimal Price {get; set;}
}