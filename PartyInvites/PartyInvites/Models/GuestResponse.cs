using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Proszę podać swoje imię i Nazwisko.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać adres e-mail.")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Proszę podać prawidłowy adres e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać prawidłowy numer telefonu.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Proszę określić, czy weźmiesz udział.")]
        public bool? WillAttend { get; set; }
    }
}