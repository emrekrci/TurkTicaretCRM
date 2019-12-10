using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkTicaretCRM.Core.DataAccess;
using TurkTicaretCRM.Core.DataAccess.EntityFramework;
using TurkTicaretCRM.TT.Bussiness.Abstract;
using TurkTicaretCRM.TT.Bussiness.Concrete.Managers;
using TurkTicaretCRM.TT.DataAccess.Abstract;
using TurkTicaretCRM.TT.DataAccess.Concrete.EntityFramework;

namespace TurkTicaretCRM.TT.Bussiness.DependencyResolvers.Ninject
{
    public class BussinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<TTContext>();
        }
    }
}
