using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Too short username")]
        public string Username { get; set; }
        [Range(3, 100, ErrorMessage = "Invalid Age")]
        public int? Age { get; set; }
        [Range(10, 300, ErrorMessage = "Invalid Weight")]
        public double? Weight { get; set; }
        [Range(50, 240, ErrorMessage = "Invalid Height")]
        public int? Height { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Too short password")]
        public string Password { get; set; }
    }
}
