using System;
using System.ComponentModel.DataAnnotations;

namespace Serwis.Models;

public class Sprzet
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Pole jest wymagane")]
    [MinLength(3, ErrorMessage = "Pole powinno mieć co najmniej 3 znaki.")]
    [MaxLength(30, ErrorMessage = "Pole powinno mieć maksymalnie 30 znaków.")]
    public string Nazwa { get; set; }
    [Required(ErrorMessage = "Pole jest wymagane")]
    [MinLength(3, ErrorMessage = "Pole powinno mieć co najmniej 3 znaki.")]
    [MaxLength(30, ErrorMessage = "Pole powinno mieć maksymalnie 30 znaków.")]
    public string Model { get; set; }

    [Required(ErrorMessage = "Pole jest wymagane")]
    public int SerwisId { get; set; }
    public Serwiss Serwis { get; set; } 
}
