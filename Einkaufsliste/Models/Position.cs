using System.ComponentModel.DataAnnotations;

namespace Einkaufsliste.Models;

public class Position
{
    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Bitte Anzahl angeben")]
    public int Anzahl { get; set; }
    [Required(ErrorMessage = "Bitte Gesachaeft angeben")]
    public string? Geschaeft { get; set; }
    
}