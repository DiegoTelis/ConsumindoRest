using System.Data.SqlClient;
using System.Text.Json;
using WebConsumindoRest.Data;
using WebConsumindoRest.Interface;
using WebConsumindoRest.Models;

namespace WebConsumindoRest.Repositorio
{
    public class TodoRepositorio : ITodo
    {
        private readonly string url="https://jsonplaceholder.typicode.com/todos";
        private readonly BancoContext _bancoContext;

        private readonly IConfiguration _Configuration;
        public TodoRepositorio(BancoContext bancoContext,IConfiguration config)
        {
            _bancoContext = bancoContext;
            _Configuration = config;
        }

        public bool Adicionar(List<TodoModel> todos)
        {
            _bancoContext.Todos.AddRangeAsync(todos);

            _bancoContext.SaveChangesAsync();
            return true;
        }

        public bool Apagar(int id)
        {
            TodoModel todo = _bancoContext.Todos.Where(x => x.id == id).Single();
            if (todo != null)
            {
                _bancoContext.Todos.Remove(todo);
                _bancoContext.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public bool ApagarTodos()
        {
            //object p = _bancoContext.Database./*ExecuteSqlCommand*/("TRUNCATE TABLE [TableName]");
            //var builder = WebApplication.CreateBuilder();
            //var x = builder.Configuration.GetConnectionString("DefaultConnection");

            string stringConnect = WebApplication.CreateBuilder().Configuration.GetConnectionString("DefaultConnection");

            var x = _Configuration["ConnectionStrings:DefaultConnection"];

            string query = "delete from db_Contatos..Todos; ";

            using (SqlConnection connection =
            new SqlConnection(stringConnect))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return true;
        }

        public List<TodoModel> GetTodosAPI()
        {
            List<TodoModel> todos = new List<TodoModel>();
            try
            {
                using (var cliente = new HttpClient())
                {
                    var result = cliente.GetStringAsync(url);
                    result.Wait();
                    if (result != null)
                        todos = JsonSerializer.Deserialize<List<TodoModel>>(result.Result);
                }

            }
            catch (Exception)
            {

                throw;
            }
            return todos;

        }

        public List<TodoModel> GetTodosBD()
        {
            return _bancoContext.Todos.ToList();
        }

        public TodoModel UpdateTodo(TodoModel todo)
        {
            TodoModel tModel = _bancoContext.Todos.ToList().FirstOrDefault(x => x.id == todo.id);
            if (tModel == null)
                throw new Exception("Houve um problema para gravar esta alteração.");
            tModel.id = todo.id;
            tModel.userId = todo.userId;
            tModel.title = todo.title;
            tModel.completed = todo.completed;

            _bancoContext.Todos.Update(tModel);
            _bancoContext.SaveChanges();
            return tModel;
        }
    }
}
