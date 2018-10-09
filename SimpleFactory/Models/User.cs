using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimpleFactory.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Display(Name = "Login")]
        [Required(ErrorMessage ="To pole jest wymagane.")]
        public string Username { get; set; }
        [Display(Name = "Hasło")]
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "{0} musi mieć min {2} i max {1} znaków", MinimumLength = 6)]
        public string Password { get; set; }        
        public bool IsLogged { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Potwierdź hasło")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        //foreign keys
        public int RoleId { get; set; }
        public int FactoryId { get; set; }
    }
}