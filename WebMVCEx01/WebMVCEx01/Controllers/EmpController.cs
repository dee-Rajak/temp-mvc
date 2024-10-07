using Microsoft.AspNetCore.Mvc;
using WebMVCEx01.Models;

namespace WebMVCEx01.Controllers
{
    public class EmpController : Controller
    {
        private static List<Emp> employees = new List<Emp>
    {
        new Emp { EId = 1, EName = "Sam Dicosta", EDesignation = "Manager", EDOJ = new DateTime(2020, 1, 1) },
        new Emp { EId = 2, EName = "Jane Deez", EDesignation = "Developer", EDOJ = new DateTime(2021, 2, 15) },
    };

        public ActionResult Index()
        {
            return View(employees);
        }
    }
}
