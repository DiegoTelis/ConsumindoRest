using WebConsumindoRest.Models;

namespace WebConsumindoRest.Interface
{
    public interface ITodo
    {
        List<TodoModel> GetTodosAPI();
        List<TodoModel> GetTodosBD();
        bool Adicionar(List<TodoModel> todo);
        TodoModel UpdateTodo(TodoModel todo);
        bool ApagarTodos();
        bool Apagar(int id);




    }
}
