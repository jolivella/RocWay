using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocWay.Application.DTO;
using RocWay.Application.Interface;

namespace RocWay.Web.Controllers
{
    public class CustomerController : Controller
    {

        readonly ICustomerApplication customerApplication;

        public CustomerController(ICustomerApplication CustomerApplication)
        {
            customerApplication = CustomerApplication;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            var customers = customerApplication.GetAll();
            return View(customers);
        }

        // GET: CustomerController/Details/5
        /*public ActionResult Details(int id)
        {
            return View();
        }*/

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            CustomerDto customerDto = new CustomerDto();
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerDto customer)
        {
            try
            {
                var inserted = customerApplication.Insert(customer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
