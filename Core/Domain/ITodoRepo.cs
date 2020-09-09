using System.Collections.Generic;
using Entities;
namespace Core.Domain
{
    public interface ITodoRepo
    {
        IEnumerable<Todo> ReadAll();
        Todo TodoById(int id);
        Todo AddTodo(Todo add);
        Todo UpdateTodo(Todo upd);
        int DeleteTodo(Todo del);
    }
}