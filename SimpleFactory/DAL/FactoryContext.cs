﻿using SimpleFactory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SimpleFactory.DAL
{
    public class FactoryContext : DbContext
    {

        public FactoryContext() : base("FactoryContext")
        {

        }

        static FactoryContext()
        {
            Database.SetInitializer<FactoryContext>(new FactoryInitializer());
        }

 

        public DbSet<Employer> Employers { get; set; }
        public DbSet<Factory> Factories { get; set; }

        public System.Data.Entity.DbSet<SimpleFactory.Models.User> Users { get; set; }
    }


    /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Wylacza konwencje, ktora towrzy liczbę mnogą dla nazw tabel

        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


    }*/


}