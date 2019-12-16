using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurkTicaretCRM.TT.Bussiness.Abstract;

namespace TurkTicaretCRM.TT.Mvc.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerManage()
        {
            return View();
        }

        public ActionResult GetAllCustomers()
        {
            var result = _customerService.GetAll();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}