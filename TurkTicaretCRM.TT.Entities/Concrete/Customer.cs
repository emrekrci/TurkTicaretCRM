using System;
using System.Collections.Generic;
using System.Text;
using TurkTicaretCRM.Core.Entities;

namespace TurkTicaretCRM.TT.Entities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerMail { get; set; }
        public string CustomerAddress { get; set; }
    }
}
