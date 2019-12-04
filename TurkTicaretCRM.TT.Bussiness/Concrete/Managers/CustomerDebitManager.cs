using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkTicaretCRM.TT.Bussiness.Abstract;
using TurkTicaretCRM.TT.DataAccess.Abstract;
using TurkTicaretCRM.TT.Entities.Concrete;

namespace TurkTicaretCRM.TT.Bussiness.Concrete.Managers
{
    public class CustomerDebitManager : ICustomerDebitService
    {
        private ICustomerDebitDal _customerDebitDal;
        public CustomerDebitManager(ICustomerDebitDal customerDebitsDal)
        {
            _customerDebitDal = customerDebitsDal;
        }
        public CustomerDebit GetById(int id)
        {
            return _customerDebitDal.Get(x => x.CustomerDebitID == id);
        }
    }
}
