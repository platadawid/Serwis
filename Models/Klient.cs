using System.ComponentModel.DataAnnotations;

namespace Serwis.Models;

public class Klient
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Pole jest wymagane")]
    [MinLength(3, ErrorMessage = "Pole powinno mieć co najmniej 3 znaki.")]
    [MaxLength(20, ErrorMessage = "Pole powinno mieć maksymalnie 20 znaków.")]
    public string Imie { get; set; }

    [Required(ErrorMessage = "Pole jest wymagane")]
    [MinLength(3, ErrorMessage = "Pole powinno mieć co najmniej 3 znaki.")]
    [MaxLength(20, ErrorMessage = "Pole powinno mieć maksymalnie 20 znaków.")]
    public string Nazwisko { get; set; }

    [Required(ErrorMessage = "Pole jest wymagane")]
    [MinLength(9, ErrorMessage = "Pole powinno mieć co najmniej 9 znaków.")]
    [MaxLength(9, ErrorMessage = "Pole powinno mieć maksymalnie 9 znaków.")]
    public string Telefon { get; set; }

    public ICollection<Serwiss> Serwisy { get; set; } 
}
