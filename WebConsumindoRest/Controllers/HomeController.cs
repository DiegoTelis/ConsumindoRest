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
            var todos = _todo.GetTodosBD();
            if (todos == null || !todos.Any())
            {
                todos = _todo.GetTodosAPI();
                _todo.Adicionar(todos);
                TempData["MenssagemSucesso"] = "Todos - baixados com sucesso!";
            }

            if (string.IsNullOrEmpty(searchString))
                return View(todos.OrderBy(x => x.id).ToList());
            return View(todos.Where(x => x.title.Contains(searchString)).OrderBy(x => x.id).ToList());
        }
        public IActionResult Detalhes(int id)
        {
            var xpto = _todo.GetTodosBD();
            TodoModel todo = xpto.Where(x => x.id == id).FirstOrDefault();
            if (todo != null)
                return View(todo);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Alterar(TodoModel todo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _todo.UpdateTodo(todo);
                    TempData["MenssagemSucesso"] = "Todo alterado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View("Detalhes", todo);
            }
            catch (Exception ex)
            {
                TempData["MenssagemErro"] = $"Não foi possivel Alterar esse contato! Detalhes: {ex.Message}";
                return RedirectToAction("Index"); ;
            }

        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult BaixarBD()
        {
            try
            {
                _todo.Adicionar(_todo.GetTodosAPI());

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index");
            }
        }
        public IActionResult BaixarDefaltToBD()
        {
            try
            {

                _todo.ApagarTodos();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index");
            }
        }
        public IActionResult Apagar(int id)
        {
            try
            {

                _todo.Apagar(id);
                TempData["MenssagemSucesso"] = "Todo excluido com sucesso!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["MenssagemErro"] = $"Não foi possivel Alterar esse contato! Detalhes: {ex.Message}";
                return RedirectToAction("Index");
            }
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}