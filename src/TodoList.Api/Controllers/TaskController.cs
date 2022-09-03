using Microsoft.AspNetCore.Mvc;

namespace TodoList.Api.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
