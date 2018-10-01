using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SimpleFactory.Models;
using System.Data.Entity.Migrations;

namespace SimpleFactory.DAL
{
    public class FactoryInitializer : DropCreateDatabaseAlways<FactoryContext>
    {

        protected override void Seed(FactoryContext context)
        {
            SeedFactoryData(context);

            base.Seed(context);
        }

        public static void SeedFactoryData(FactoryContext context)
        {
            var employers = new List<Employer>
            {
                new Employer() { EmployerId = 1, FirstName = "Janek", LastName = "Bambus", FactoryId = 1, PhoneNumber = "556523265" },
                new Employer() { EmployerId = 2, FirstName = "Łucjan", LastName = "Banan", FactoryId = 1, PhoneNumber = "55652435" },
                new Employer() { EmployerId = 3, FirstName = "Przemek", LastName = "Arbuz", FactoryId = 2, PhoneNumber = "55655365" },
                new Employer() { EmployerId = 4, FirstName = "Jakub", LastName = "Trzon", FactoryId = 2, PhoneNumber = "55652655" },
                new Employer() { EmployerId = 5, FirstName = "Andrzej", LastName = "Kimon", FactoryId = 3, PhoneNumber = "55652343" },
                new Employer() { EmployerId = 6, FirstName = "Patryk", LastName = "Tafla", FactoryId = 3, PhoneNumber = "55652666" },
            };


            employers.ForEach(x => context.Employers.AddOrUpdate(x));
            context.SaveChanges();


            var factories = new List<Factory>
            {
                 new Factory() { FactoryId = 1, FactoryName="Firma1"},
                 new Factory() { FactoryId = 2, FactoryName="Firma2"},
                 new Factory() { FactoryId = 3, FactoryName="Firma3"},
            };

            factories.ForEach(x => context.Factories.AddOrUpdate(x));
            context.SaveChanges();

        }
    }
}