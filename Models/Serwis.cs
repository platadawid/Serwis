using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Serwis.Models;

public class Serwiss
{
    [ValidateNever]
    public int Id { get; set; }
    [Required(ErrorMessage = "Pole jest wymagane")]
    [MinLength(3, ErrorMessage = "Pole powinno mieć co najmniej 3 znaki.")]
    [MaxLength(20, ErrorMessage = "Pole powinno mieć maksymalnie 20 znaków.")]
    public string Nazwa { get; set; }
    [Required(ErrorMessage = "Pole jest wymagane")]
    [MinLength(10, ErrorMessage = "Pole powinno mieć co najmniej 10 znaków.")]
    [MaxLength(200, ErrorMessage = "Pole powinno mieć maksymalnie 200 znaków.")]
    public string Opis { get; set; }
    
    [Required(ErrorMessage = "Pole jest wymagane")]
    public DateTime DataZgloszenia { get; set; }

    [Required(ErrorMessage = "Pole jest wymagane")]
    public int KlientId { get; set; }
    public Klient Klient { get; set; } 
}
