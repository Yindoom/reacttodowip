using System.Collections.Generic;
using Entities;
using Core.Domain;

namespace Core.Service.Impl
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepo _repo;

        public TodoService(ITodoRepo repo)
        {
            _repo = repo;
        }
        public Todo AddTodo(Todo todo)
        {
            return _repo.AddTodo(todo);
        }

        public int DeleteTodo(int id)
        {
            var del = _repo.TodoById(id);
            return _repo.DeleteTodo(del);
        }

        public IEnumerable<Todo> ReadAll()
        {
            return _repo.ReadAll();
        }

        public Todo TodoById(int id)
        {
            return _repo.TodoById(id);
        }

        public Todo UpdateTodo(int id, Todo todo)
        {
            todo.Id = id;
            return _repo.UpdateTodo(todo);
        }
    }
}