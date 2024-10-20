using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            var data = new TestViewModel(){
                Name = "David",
            };
            return View( data);
        }

    }
}
