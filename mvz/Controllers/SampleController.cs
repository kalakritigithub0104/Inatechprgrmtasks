using KoreMvz.Models;
using Microsoft.AspNetCore.Mvc;

namespace KoreMvz.Controllers
{
    public class SampleController : Controller
    {
        //public string hello() 
        //{
        //    return "Happy Valentine's Day";
        //}
        //public string hello(string name)
        //{
        //    return "Happy Valentine's Day dear "+name ;
        //}
        public string hello(string name,int no)
        {
            return "Happy Valentine's Day dear " + name + "And you are the " + no + " Visitor";
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index(string name,int no)
        {
            ViewData["name"] = name;
            ViewData["no"] = no;
            return View();
        }
        public IActionResult GetCustomer() 
        {
            Customer cust = new Customer() { CustomerId = 101, CustomerName = "Ram", Gender = "Male", City = "Chennai", ContactNo = "9780976543" };
            return View("CustomerDisplay",cust);
        }
        public IActionResult NewCustomer()
        {
        return View();
        }
        public IActionResult SubmitCustomer(Customer customer)
        {
            // return RedirectToAction("GetCustomer");
            return View("CustomerDisplay", customer);
        }
        public IActionResult GetMember()
        {
            return View("CustomerMembership");
        }
    }
}
