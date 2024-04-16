using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var customers = new List<Customer>();
            customers.Add(new Customer(1234567, "Feras Alshadad", "f@gmail.com", 34567898));
            customers.Add(new Customer(0987602, "Fahad Ahmed", "f1@gmail.com", 45678761));
            customers.Add(new Customer(0098763, "Fawaz Bader", "f2@gmail.com", 34567654));
            customers.Add(new Customer(0345304, "Faisal Talal", "f@3gmail.com", 23456762));

            return View(customers);
        }
    }
}
