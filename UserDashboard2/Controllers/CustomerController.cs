using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserDashboard2.Models;

namespace UserDashboard2.Controllers
{
    public class CustomerController : Controller
    {
        CustomerDataContext objDataContext = new CustomerDataContext();
        // GET: Customer  
        public ActionResult CustomerDetails()
        {

            return View(objDataContext.Customers.ToList());
        }
        public ActionResult create()
        {
            var custList = new List<string>() { "TCS", "WIPRO", "ACCENTURE", "IBM" };
            ViewBag.list = custList;
            return View();
        }
        [HttpPost]
        public ActionResult create(customerInfo objCustomer)
        {
            var custList = new List<string>() { "TCS", "WIPRO", "ACCENTURE", "IBM" };
            ViewBag.list = custList;
            objDataContext.Customers.Add(objCustomer);            
            objDataContext.SaveChanges();
            return View();
        }
        public ActionResult Edit(string id)
        {
            int custId = Convert.ToInt32(id);
            var customer = objDataContext.Customers.Find(custId);
            var custList = new List<string>() { "TCS", "WIPRO", "ACCENTURE", "IBM" };
            ViewBag.list = custList;
            return View(customer);
        }
        [HttpPost]
        public ActionResult Edit(customerInfo objCust, FormCollection form)
        {            
            var data = objDataContext.Customers.Find(objCust.CustId);
            var custList = new List<string>() { "TCS", "WIPRO", "ACCENTURE", "IBM" };
            ViewBag.list = custList;
            if (data != null)
            {
                data.Email = objCust.Email;
                data.FirstName = objCust.FirstName;
                data.LastName = objCust.LastName;
                data.TrialUser = objCust.TrialUser;
                data.Username = objCust.Username;
                data.ListOfCustomers = objCust.ListOfCustomers;                
                data.globalGleasonAdmin = objCust.globalGleasonAdmin;
                data.user = objCust.user;
                data.customerAdmin = objCust.customerAdmin;
                data.rsm = objCust.rsm;
                data.gleasonInternalSales = objCust.gleasonInternalSales;
                data.sE = objCust.sE;
            }            
            objDataContext.SaveChanges();
            return View();
        }

        public ActionResult Delete(string id)
        {
            int custId = Convert.ToInt32(id);
            var cust = objDataContext.Customers.Find(custId);
            objDataContext.Customers.Remove(cust);
            objDataContext.SaveChanges();            
            return RedirectToAction("CustomerDetails");            
        }
        
        // GET: Customer
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}