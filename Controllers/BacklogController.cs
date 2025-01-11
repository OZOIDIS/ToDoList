using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class BacklogController : Controller
    {
        [Route("backlog")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
