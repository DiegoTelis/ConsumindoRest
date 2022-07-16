using System.Text.Json;
using WebConsumindoRest.Interface;
using WebConsumindoRest.Models;

namespace WebConsumindoRest.Repositorio
{
    public class TodoRepositorio : ITodo
    {
        private readonly string url="https://jsonplaceholder.typicode.com/todos";
        public List<Todo> GetTodos()
        {
            List<Todo> todos = new List<Todo>();
            try
            {
                using (var cliente = new HttpClient())
                {
                    var result = cliente.GetStringAsync(url);
                    result.Wait();
                    if (result != null)
                        todos = JsonSerializer.Deserialize<List<Todo>>(result.Result);
                }

            }
            catch (Exception)
            {

                throw;
            }
            return todos;

        }
    }
}
