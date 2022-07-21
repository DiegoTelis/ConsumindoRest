using FormConsumindoRest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormConsumindoRest.Repositorio
{
    public  interface ITodoRepositorio
    {
        List<Todo> GetTodosAPI();
        List<Todo> GetTodosBD();
        List<Todo> GetTodosPorDescricao(string descTodo);
        Todo GetTodoPorID(int id);
        Todo UpdateTodo(int id);
        bool DeleteTodoPorId(int id);
        bool DeleteTodos();

    }
}
