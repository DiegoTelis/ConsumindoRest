using FormConsumindoRest.Data;
using FormConsumindoRest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FormConsumindoRest.Repositorio
{
    public class TodoRepositorio : ITodoRepositorio
    {
        private readonly string url = "https://jsonplaceholder.typicode.com/todos";
        private readonly BancoContext _bancoContext;

        public TodoRepositorio()
        {
        }

        public bool DeleteTodoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTodos()
        {
            throw new NotImplementedException();
        }

        public Todo GetTodoPorID(int id)
        {
            throw new NotImplementedException();
        }

        
        public List<Todo> GetTodosAPI()
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

        public List<Todo> GetTodosBD()
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetTodosPorDescricao(string descTodo)
        {
            throw new NotImplementedException();
        }

        public Todo UpdateTodo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
