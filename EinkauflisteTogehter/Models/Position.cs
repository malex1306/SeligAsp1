using System.ComponentModel.DataAnnotations;

namespace EinkauflisteTogehter.Models;

public class Position
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Bitte geben Sie einen Namen ein")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Bitte geben Sie eine Anzahle ein")]
    [Range(1, 50, ErrorMessage = "Bitte im Bereich 1-50")]
    public int Anzahl { get; set; }
    [Required(ErrorMessage = "Bitte geben Sie ein Geschäft an")]
    public string? Geschaeft { get; set; }
}