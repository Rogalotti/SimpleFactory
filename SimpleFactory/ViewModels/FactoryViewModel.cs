using SimpleFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimpleFactory.ViewModels
{
    public class FactoryViewModel
    {
        public int EmployerId { get; set; }
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Display(Name = "Nr telefonu")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Firma")]
        public int FactoryId { get; set; }
        [Display(Name = "Nazwa firmy")]
        public string FactoryName { get; set; }
        public IEnumerable<Employer> Employers { get; set; }
        public Factory Factories { get; set; }
    }
}