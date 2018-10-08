using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimpleFactory.Models
{
    public class Employer
    {
        public int EmployerId { get; set; }
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Display(Name = "Nr telefonu")]
        public string PhoneNumber { get; set; }

        //foreign key factory
        [Display(Name = "Firma")]
        public int FactoryId { get; set; }
    }
}