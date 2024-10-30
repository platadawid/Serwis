using System;
using System.ComponentModel.DataAnnotations;

namespace Serwis.Models;

public class Naprawa
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Pole jest wymagane")]
    [MinLength(10, ErrorMessage = "Pole powinno mieć co najmniej 10 znaków.")]
    [MaxLength(200, ErrorMessage = "Pole powinno mieć maksymalnie 200 znaków.")]
    public string Opis { get; set; }
    [Required(ErrorMessage = "Pole jest wymagane")]
    public decimal Koszt { get; set; }
    [Required(ErrorMessage = "Pole jest wymagane")]
    public DateTime DataNaprawy { get; set; }

    public int SerwisId { get; set; }
    public Serwiss Serwis { get; set; } 
}
