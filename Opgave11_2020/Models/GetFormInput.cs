using System;
using System.ComponentModel.DataAnnotations;

namespace Opgave11_2020.Models
{
    public class GetFormInput
    {
        [Required]
        [StringLength(20, MinimumLength = 2,
            ErrorMessage = "Dit fornavn skal have mellem 2-20 bogstaver")]
        public string firstName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2,
            ErrorMessage = "Dit efternavn skal have mellem 2-30 bogstaver")]
        public string lastName { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string email { get; set; }

        [Required]
        public int phone { get; set; }
    }
}