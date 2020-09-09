using System.Collections.Generic;
using Entities;

namespace Core.Service
{
    public interface ITodoService
    {
        IEnumerable<Todo> ReadAll();
        Todo TodoById(int id);
        Todo AddTodo(Todo todo);
        Todo UpdateTodo(int id, Todo todo);
        int DeleteTodo(int id);
    }
}