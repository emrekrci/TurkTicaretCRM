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
    public class DebitManager:IDebitService
    {
        private IDebitDal _debitDal;
        public DebitManager(IDebitDal debitDal)
        {
            _debitDal = debitDal;
        }

        public Debit GetById(int id)
        {
            return _debitDal.Get(x => x.DebitID == id);
        }
    }
}
