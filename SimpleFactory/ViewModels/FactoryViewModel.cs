using SimpleFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleFactory.ViewModels
{
    public class FactoryViewModel
    {
        public IEnumerable<Employer> Employers { get; set; }
        public Factory Factories { get; set; }
    }
}