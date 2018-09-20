using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleFactory.Models
{
    public class Employer
    {
        public int EmployerId { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        //foreign key factory
        public int FactoryId { get; set; }
    }
}