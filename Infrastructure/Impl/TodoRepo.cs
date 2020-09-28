using System.Collections.Generic;
using Core.Domain;
using System.Linq;
using Entities;

namespace Infrastructure.Impl
{
    public class TodoRepo : ITodoRepo
    {
        private readonly TodoContext _ctx;
        public TodoRepo(TodoContext ctx)
        {
            _ctx = ctx;
        }
        public Todo AddTodo(Todo todo)
        {
            var added = _ctx.Tasks.Add(todo).Entity;
            _ctx.SaveChanges();
            return added;
        }

        public int DeleteTodo(Todo del)
        {
            var deleted = _ctx.Tasks.Remove(del).Entity;
            _ctx.SaveChanges();
            return deleted.Id;
        }

        public IEnumerable<Todo> ReadAll()
        {
            return this._ctx.Tasks;
        }

        public Todo TodoById(int id)
        {
            return _ctx.Tasks.FirstOrDefault(u => u.Id == id);
        }

        public Todo UpdateTodo(Todo todo)
        {
            var updated = _ctx.Tasks.Update(todo).Entity;
            _ctx.SaveChanges();
            return updated;
        }
    }
}