using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using TurkTicaretCRM.TT.DataAccess.Concrete.EntityFramework.Mappings;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.DataAccess.Concrete.EntityFramework
{
    public class TTContext:DbContext
    {
        public TTContext() :base()
        {
            //Database.SetInitializer<TTContext>(null);
        }
        public DbSet<Customer> Customers { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Configurations.Add(new CustomerMap());
        //}
    }
}
