using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        #region RoutingDoc
        //literal -> product
        //parameter (required) -> {category}
        //          (optional) -> {category?}
        //          (default)  -> {category=pro}
        //          (constrain)-> {category:string}
        //          (complex constraint) -> {qty:int:max(10)?}
        //          (catch all)-> {**others}
        //
        //Route values are captured by and stored in a dictionary typically used for model binding
        //Routing only matches URL template segments and doesn't know anything about the data you're expecting those route parameters to contain by default.
        //You can define a large number of constraints, and its also possible to define more complex ones like regex or min and max.
        //WARNING Don’t use route constraints to validate general input, such as to check that an email address is valid. Constraints should be used sparingly.
        //
        #endregion
        //home/{today}
        //home/{tomorrow}
        [Route("[action]")]
        [Route("today")]
        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}