using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimpleFactory.Models
{
    public class Factory
    {
        public int FactoryId { get; set; }
        [Display(Name = "Nazwa firmy")]
        public string FactoryName { get; set; }
    }
}