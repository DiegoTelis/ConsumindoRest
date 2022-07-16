using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebConsumindoRest.Interface;
using WebConsumindoRest.Models;


namespace WebConsumindoRest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITodo _todo;


        public HomeController(ITodo iTodo)
        {
            _todo = iTodo;
        }

        public IActionResult Index(string searchString)
        {
            var todos = _todo.GetTodos();

            if (string.IsNullOrEmpty(searchString))
                return View(todos);
            return View(todos.Where(x => x.title.Contains(searchString)).ToList());
        }
        public IActionResult Detalhes(int id)
        {
            var xpto = _todo.GetTodos();
            Todo todo = xpto.Where(x => x.id == id).FirstOrDefault();
            if (todo != null)
                return View(todo);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
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