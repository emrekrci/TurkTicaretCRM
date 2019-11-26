using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CustomerMap: EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable(@"Customers", @"dbo");
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName("CustomerId");
            Property(x => x.CustomerName).HasColumnName("CustomerName");
            Property(x => x.CustomerSurname).HasColumnName("CustomerSurname");
            Property(x => x.CustomerPhone).HasColumnName("CustomerPhone");
            Property(x => x.CustomerMail).HasColumnName("CustomerMail");
            Property(x => x.CustomerAddress).HasColumnName("CustomerAddress");
        }
    }
}
